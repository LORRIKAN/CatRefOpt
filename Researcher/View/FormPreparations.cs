using Model.CatRef;
using Researcher.Shared;
using Researcher.View.InterfaceElements;
using Researcher.View.InterfaceElements.ParamsIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Researcher.View
{
    public partial class ResearcherForm
    {
        public event Func<int>? GetAllocatedMemoryInMb;

        public event Func<(VariableParameterWithValue N, VariableParameterWithValue M)> GetValuesTableSizeParams = null!;

        public event Func<DataSource> GetPlants = null!;

        public event Func<Plant?, DataSource> GetReactors = null!;

        public event Func<Plant?, DataSource> GetMaterials = null!;

        public event Func<Plant?, DataSource> GetCatalysts = null!;

        public event Func<Plant?, DataSource> GetMathModels = null!;

        public event Func<MatlabMathModel?, DataSource> GetTargetFuncs = null!;

        public event Func<Reactor?, MatlabMathModel?, IEnumerable<Parameter>> GetReactorInputParams = null!;

        public event Func<Material?, MatlabMathModel?, IEnumerable<Parameter>> GetMaterialInputParams = null!;

        public event Func<Catalyst?, MatlabMathModel?, IEnumerable<Parameter>> GetCatalystInputParams = null!;

        public event Func<Plant?, MatlabMathModel?, IEnumerable<VariableParameterWithValue>> GetVariableParams = null!;

        public event Func<MatlabOptimizationMethod?, IEnumerable<VariableParameterWithValue>> GetOptimMethodParams = null!;

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            SetDependentButtonsMasterControls();
            SetComboBoxesDataSources();
            SetComboBoxesDependentControls();
            OtherPreparations();
        }

        private void SetComboBoxesDataSources()
        {
            plantOptim.GetDataSource += _ => GetPlants();
            reactorOptim.GetDataSource += _ => GetReactors(plantOptim.SelectedItem as Plant);
            materialOptim.GetDataSource += _ => GetMaterials(plantOptim.SelectedItem as Plant);
            catalystOptim.GetDataSource += _ => GetCatalysts(plantOptim.SelectedItem as Plant);
            targetFuncChoosePanel.MathModelComboBox.GetDataSource += _ => GetMathModels(plantOptim.SelectedItem as Plant);
            optimMethod.GetDataSource += _ => targetFuncChoosePanel.AvailableOptimMethods;

            plantVis.GetDataSource += _ => GetPlants();
            reactorVis.GetDataSource += _ => GetReactors(plantOptim.SelectedItem as Plant);
            materialVis.GetDataSource += _ => GetMaterials(plantOptim.SelectedItem as Plant);
            catalystVis.GetDataSource += _ => GetCatalysts(plantOptim.SelectedItem as Plant);
            mathModelVis.GetDataSource += _ => GetMathModels(plantOptim.SelectedItem as Plant);
            targetFuncVis.GetDataSource += _ => GetTargetFuncs(mathModelVis.SelectedItem as MatlabMathModel);
        }

        private void SetComboBoxesDependentControls()
        {
            plantOptim.AddDependentControl(reactorOptim);
            plantOptim.AddDependentControl(materialOptim);
            plantOptim.AddDependentControl(catalystOptim);
            plantOptim.AddDependentControl(targetFuncChoosePanel.MathModelComboBox);

            reactorOptim.AddDependentControl(reactorParamsOptim, (_, r)
                => ParamsIOGetter.GetParamsOutputs(GetReactorInputParams(r as Reactor, targetFuncChoosePanel.MathModel)));

            materialOptim.AddDependentControl(materialParamsOptim, (_, m)
                => ParamsIOGetter.GetParamsOutputs(GetMaterialInputParams(m as Material, targetFuncChoosePanel.MathModel)));

            catalystOptim.AddDependentControl(catalystParamsOptim, (_, c)
                => ParamsIOGetter.GetParamsOutputs(GetCatalystInputParams(c as Catalyst, targetFuncChoosePanel.MathModel)));

            optimMethod.AddDependentControl(optimParams, (_, m)
                => ParamsIOGetter.GetParamsInputs(GetOptimMethodParams(m as MatlabOptimizationMethod)));

            targetFuncChoosePanel.TargetFuncComboBox.AddDependentControl(optimMethod);
            targetFuncChoosePanel.MathModelComboBox.AddDependentControl(variableParamsOptim, (_, mm)
                => ParamsIOGetter.GetVariableOrInputParams(GetVariableParams(plantOptim.SelectedItem as Plant, mm as MatlabMathModel)));
            targetFuncChoosePanel.MathModelComboBox.SelectedIndexChanged += (_, _) =>
            {
                reactorOptim.RearrangeDependentControls();
                materialOptim.RearrangeDependentControls();
                catalystOptim.RearrangeDependentControls();
            };

            plantVis.AddDependentControl(reactorVis);
            plantVis.AddDependentControl(materialVis);
            plantVis.AddDependentControl(catalystVis);
            plantVis.AddDependentControl(mathModelVis);

            reactorVis.AddDependentControl(reactorParamsVis, (_, r)
                => ParamsIOGetter.GetParamsOutputs(GetReactorInputParams(r as Reactor, mathModelVis.SelectedItem as MatlabMathModel)));

            materialVis.AddDependentControl(materialParamsVis, (_, m)
                => ParamsIOGetter.GetParamsOutputs(GetMaterialInputParams(m as Material, mathModelVis.SelectedItem as MatlabMathModel)));

            catalystVis.AddDependentControl(catalystParamsVis, (_, c)
                => ParamsIOGetter.GetParamsOutputs(GetCatalystInputParams(c as Catalyst, mathModelVis.SelectedItem as MatlabMathModel)));

            mathModelVis.AddDependentControl(targetFuncVis);
            mathModelVis.AddDependentControl(variableParamsVis, (_, mm)
                => ParamsIOGetter.GetVariableOrInputParams(GetVariableParams(plantVis.SelectedItem as Plant, mm as MatlabMathModel)));
            mathModelVis.SelectedIndexChanged += (_, _) =>
            {
                reactorVis.RearrangeDependentControls();
                materialVis.RearrangeDependentControls();
                catalystVis.RearrangeDependentControls();
            };
        }

        private void SetDependentButtonsMasterControls()
        {
            helpButtOnOptimMethod.ValidatableContainerLogic.AddControl(optimMethod);

            startOptimButt.ValidatableContainerLogic.AddControlsRange(targetFuncChoosePanel, optimMethod,
                variableParamsOptim, startingPointOptim, optimParams);

            helpButtOnMathModelVis.ValidatableContainerLogic.AddControl(mathModelVis);

            build2DPathButt.ValidatableControlLogic.ValidationFunc += (_, e) => e.Cancel = e.Cancel || !CanBuildPathPlot();
            build3DPathButt.ValidatableControlLogic.ValidationFunc += (_, e) => e.Cancel = e.Cancel || !CanBuildPathPlot();

            build2DPlotButt.ValidatableContainerLogic.AddControlsRange(targetFuncVis,
                variableParamsVis);
            build3DPlotButt.ValidatableContainerLogic.AddControlsRange(targetFuncVis,
                variableParamsVis);
            buildValuesTableButt.ValidatableContainerLogic.AddControlsRange(targetFuncVis,
                variableParamsVis, valuesTableSizeN, valuesTableSizeM);
        }

        private void OtherPreparations()
        {
            var sizeParams = GetValuesTableSizeParams();
            valuesTableSizeN.Parameter = sizeParams.N;
            valuesTableSizeM.Parameter = sizeParams.M;

            variableParamsOptim.VariableParamsCountChanged += sender =>
            {
                startingPointOptim.Controls.Clear();

                var variableParams = sender.VariableParams.OfType<VariableParameterWithValue>()
                    .Select(vp =>
                    {
                        var newVp = vp.Copy();
                        newVp.ParameterType = ParameterType.InputEssential;
                        return newVp;
                    });

                startingPointOptim.Controls.AddRange(ParamsIOGetter
                    .GetVariableParamsInputs(variableParams).ToArray());
            };
            variableParamsOptim.ValidatableControlLogic.ValidationFunc += (_, e) =>
                e.Cancel = e.Cancel || variableParamsOptim.CurrVariableParams < 1;

            variableParamsOptim.VariableParamsCountChanged += sender => sender.ValidatableControlLogic.TryValidate();

            variableParamsVis.ValidatableControlLogic.ValidationFunc += (_, e) =>
                    e.Cancel = e.Cancel || variableParamsVis.CurrVariableParams is not 2;

            variableParamsVis.VariableParamsCountChanged += sender => sender.ValidatableControlLogic.TryValidate();

            plantOptim.SetDataSource();
            plantVis.SetDataSource();

            Task.Run(async () =>
            {
                while (true)
                {
                    await Task.Delay(1000);

                    string allocatedMem = "Потребляемая оперативная память (без учёта MATLAB): Не удалось получить данные.";

                    if (GetAllocatedMemoryInMb is not null)
                        allocatedMem = $"Потребляемая оперативная память (без учёта MATLAB): " +
                        $"≈{GetAllocatedMemoryInMb()} Мб.";

                    Invoke(() => allocatedMemShow.Text = allocatedMem);

                    if (GetAllocatedMemoryInMb is null)
                        return;
                }
            });
        }
    }
}
