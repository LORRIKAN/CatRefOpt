using Model.CatRef;
using Researcher.Shared;
using Researcher.View.InterfaceElements.ParamsIO.NumericsValidation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Researcher.Presenter
{
    public partial class ResearcherPresenter
    {
        private IEnumerable<VariableParameterWithValue> Form_GetOptimMethodParams(
            MatlabOptimizationMethod? optimMethod)
        {
            return optimMethod?.ParameterOfOptimizationMethods.Select(vp => new VariableParameterWithValue(vp))
                ?? Array.Empty<VariableParameterWithValue>();
        }

        private IEnumerable<VariableParameterWithValue> Form_GetVariableParams(Plant? plant, MatlabMathModel? mathModel)
        {
            if (plant is null || mathModel is null)
                return Array.Empty<VariableParameterWithValue>();
            return plant.VariableParameters.Where(p => p.MathModelId == mathModel.Id).Select(vp => new VariableParameterWithValue(vp));
        }

        private IEnumerable<Parameter> Form_GetCatalystInputParams(Catalyst? catalyst, MatlabMathModel? mathModel)
        {
            if (catalyst is null || mathModel is null)
                return Array.Empty<Parameter>();
            return catalyst.CatalystParameters.Where(p => p.MathModelId == mathModel.Id).Select(ip => new Parameter(ip));
        }

        private IEnumerable<Parameter> Form_GetMaterialInputParams(Material? material, MatlabMathModel? mathModel)
        {
            if (material is null || mathModel is null)
                return Array.Empty<Parameter>();
            return material.MaterialParameters.Where(p => p.MathModelId == mathModel.Id).Select(ip => new Parameter(ip));
        }

        private IEnumerable<Parameter> Form_GetReactorInputParams(Reactor? reactor, MatlabMathModel? mathModel)
        {
            if (reactor is null || mathModel is null)
                return Array.Empty<Parameter>();
            return reactor.ReactorParameters.Where(p => p.MathModelId == mathModel.Id).Select(ip => new Parameter(ip));
        }

        private DataSource Form_GetTargetFuncs(MatlabMathModel? mathModel)
        {
            return (new[] { mathModel?.OctaneNumberFunc, mathModel?.SelectionFunc }, "Name", "Id");
        }

        private DataSource Form_GetMathModels(Plant? plant)
        {
            return (plant?.ModelsOfPlants.Select(mop => mop.MathModel).ToList(), "Name", "Id");
        }

        private DataSource Form_GetCatalysts(Plant? plant)
        {
            return (plant?.CatalystsOfPlants.Select(cop => cop.Catalyst).ToList(), "Name", "Id");
        }

        private DataSource Form_GetMaterials(Plant? plant)
        {
            return (plant?.MaterialsOfPlants.Select(mop => mop.Material).ToList(), "Name", "Id");
        }

        private DataSource Form_GetReactors(Plant? plant)
        {
            return (plant?.Reactors.ToList(), "Name", "Id");
        }

        private DataSource Form_GetPlants()
        {
            return (DbContext.Plants.ToList(), "Name", "Id");
        }

        private (VariableParameterWithValue N, VariableParameterWithValue M) Form_GetValuesTableSizeParams()
        {
            var N = new VariableParameterWithValue
            {
                DecimalPlaces = 0,
                Name = "Количество строк в таблице значений",
                LowerBound = 2,
                UpperBound = 100000,
                ParameterType = ParameterType.InputEssential,
                Value = 100
            };

            var M = new VariableParameterWithValue
            {
                DecimalPlaces = 0,
                Name = "Количество столбцов в таблице значений",
                LowerBound = 2,
                UpperBound = 100000,
                ParameterType = ParameterType.InputEssential,
                Value = 100
            };

            N.ParseAndCheckConditions.ParseFunc = IntParseAndCheckConditions.Parse;
            M.ParseAndCheckConditions.ParseFunc = IntParseAndCheckConditions.Parse;

            return (N, M);
        }
    }
}
