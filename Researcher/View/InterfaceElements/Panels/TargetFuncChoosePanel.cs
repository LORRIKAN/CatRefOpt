using Model.CatRef;
using Researcher.Shared;
using Researcher.View.InterfaceElements.Validation;
using System.ComponentModel;
using System.Data;
using WinFormsShared;

namespace Researcher.View.InterfaceElements.Panels
{
    public partial class TargetFuncChoosePanel : UserControl, IValidatableContainer
    {
        public TargetFuncChoosePanel()
        {
            InitializeComponent();
            ValidatableContainerLogic = new(this);
            helpButt.ValidatableContainerLogic.AddControl(mathModel);

            Fo.ValueChanged += Fo_ValueChanged;
            FoInput.Parameter = Fo;
            FoInput.ValidatableControlLogic.ValidatedChanged += FoInput_ValidatableControlLogic_ValidatedChanged;

            targetFunc.SelectedIndexChanged += TargetFunc_SelectedIndexChanged;
            targetFunc.GetDataSource += TargetFunc_GetDataSource;

            mathModel.AddDependentControl(targetFunc);

            ValidatableContainerLogic.AddControlsRange(mathModel, targetFunc, FoInput);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Form = this.GetParentControlOfType<Form>();
        }

        private DataSource TargetFunc_GetDataSource(MasterComboBox arg)
        {
            List<MatlabFunc> dataSource = new();

            if (MathModel?.SelectionFunc is not null)
                dataSource.Add(MathModel.SelectionFunc);
            if (MathModel?.OctaneNumberFunc is not null)
                dataSource.Add(MathModel.OctaneNumberFunc);

            return (dataSource, "Name", "Id");
        }

        private void TargetFunc_SelectedIndexChanged(object? sender, EventArgs e)
        {
            SetFuncsTypes();
            FoInput.MeasureUnit = FoFunc?.MeasureUnit?.Designation ?? string.Empty;
            string str = "Критериальное ограничение";
            if (FoFunc is not null)
                str += $" ({FoFunc.Name})";
            FoInput.ParameterName = str;
            SetProblemLbl();
        }

        private void Fo_ValueChanged(Parameter obj)
        {
            SetProblemLbl();
        }

        private void FoInput_ValidatableControlLogic_ValidatedChanged(IValidatableControl obj)
        {
            SetProblemLbl();
        }

        private void helpButt_Click(object sender, EventArgs e)
        {
            if (MathModel is null)
            {
                MessageDialog.ShowMessage(MessageType.Error, Form, "Описание",
                    "Ошибка", "Сначала выберите математическую модель");
                return;
            }

            new DescriptionForm().Run($"Описание \"{MathModel.Name}\"", MathModel.Description ?? string.Empty);
        }

        private void SetProblemLbl()
        {
            if (!FoInput.ValidatableControlLogic.Validated)
            {
                problemLbl.Text = "Ошибка! Введены некорректные данные";
                return;
            }

            problemLbl.Text = TargetFuncType switch
            {
                FuncType.Selection => $"F->max при Nб≥{Fo} {FoInput.MeasureUnit}",
                FuncType.Octane => $"Nб->max при F≥{Fo} {FoInput.MeasureUnit}",
                _ => "Ошибка! Целевая функция не была выбрана!"
            };
        }

        private void SetFuncsTypes()
        {
            if (MathModel is null || TargetFunc is null)
            {
                TargetFuncType = FuncType.NoFunc;
                FoFuncType = FuncType.NoFunc;
                return;
            }

            if (TargetFunc.Id == MathModel.SelectionFuncId)
            {
                TargetFuncType = FuncType.Selection;
                FoFuncType = FuncType.Octane;
            }
            else
            {
                TargetFuncType = FuncType.Octane;
                FoFuncType = FuncType.Selection;
            }
        }

        [Browsable(false)]
        public VariableParameterWithValue Fo { get; } = new()
        {
            Name = "Критериальное ограничение",
            ParameterType = ParameterType.InputEssential,
            Value = 50,
            DecimalPlaces = 0,
            LowerBound = 0,
        };

        [Browsable(false)]
        public MasterComboBox MathModelComboBox => mathModel;

        [Browsable(false)]
        public MasterComboBox TargetFuncComboBox => targetFunc;

        [Browsable(false)]
        public MatlabMathModel? MathModel => mathModel.SelectedItem as MatlabMathModel;

        [Browsable(false)]
        public MatlabFunc? TargetFunc => targetFunc.SelectedItem as MatlabFunc;

        [Browsable(false)]
        public MatlabFunc? FoFunc => FoFuncType switch
        {
            FuncType.Octane => MathModel?.OctaneNumberFunc,
            FuncType.Selection => MathModel?.SelectionFunc,
            _ => null
        };

        [Browsable(false)]
        public FuncType TargetFuncType { get; private set; }

        [Browsable(false)]
        public FuncType FoFuncType { get; private set; }

        [Browsable(false)]
        public DataSource AvailableOptimMethods 
        { 
            get
            {
                if (TargetFuncType is FuncType.NoFunc)
                    return new(Array.Empty<MatlabOptimizationMethod>(), string.Empty, string.Empty);
                
                return new(TargetFunc!.SupportableFuncs.Select(sf => sf.OptimizationMethod).ToArray(),
                    "Name",
                    "Id");
            } 
        }

        public ValidatableControlLogic ValidatableControlLogic => ValidatableContainerLogic;

        public ValidatableContainerLogic ValidatableContainerLogic { get; private set; } = null!;

        private Form? Form { get; set; }
    }

    public enum FuncType
    {
        Selection,
        Octane,
        NoFunc
    }
}
