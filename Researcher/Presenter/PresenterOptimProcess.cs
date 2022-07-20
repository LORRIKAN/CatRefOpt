using OptimizationMatlab;
using Researcher.Shared;
using Researcher.Shared.Messages.VisOptimMsgs;

namespace Researcher.Presenter
{
    public partial class ResearcherPresenter
    {
        private Presenter_Form_Optim_Msg? LastOptimResult { get; set; }

        private Form_Presenter_Optim_Msg? LastOptimRequest { get; set; }

        private Presenter_Form_Optim_Msg Form_StartOptimization(Form_Presenter_Optim_Msg msg)
        {
            var empiricalCoeffs = msg.TargetFunc.EmpiricalCoefficients.Select(ef => new Parameter(ef))
                .Concat(msg.FoFunc.EmpiricalCoefficients.Select(ef => new Parameter(ef))).ToArray();

            var inputParams = msg.ProcessInputParams
                .Concat(msg.Plant.Reactors.SelectMany(r => Form_GetReactorInputParams(r, msg.MathModel)))
                .Concat(Form_GetMaterialInputParams(msg.Material, msg.MathModel))
                .Concat(Form_GetCatalystInputParams(msg.Catalyst, msg.MathModel)).ToArray();

            var optimInput = new OptimInput
            {
                EmpiricalCoefficients = empiricalCoeffs,
                Fo = msg.Fo,
                FoFunc = msg.FoFunc,
                InputParams = inputParams,
                OptimMethod = msg.OptimMethod,
                ParamsOfOptimMethod = msg.ParamsOfOptimMethod,
                TargetFunc = msg.TargetFunc,
                VariableParams = msg.VariableParams
            };

            var result = OptimizationStarter.StartOptimization(optimInput);

            if (!string.IsNullOrEmpty(result.ErrorMsg))
                return new Presenter_Form_Optim_Msg { ErrorMsg = result.ErrorMsg };

            var methodMetrics = new List<Parameter>();

            if (result.Eps is not null)
                methodMetrics.Add(new Parameter
                {
                    Name = "Точность по функции",
                    ParameterType = ParameterType.Output,
                    Value = result.Eps
                });

            var elapsedTime = new Parameter
            {
                MeasureUnit = "с",
                Name = "Время работы метода",
                ParameterType = ParameterType.Output,
                Value = result.ElapsedTimeInSec
            };
            var funcEvalsCount = new Parameter
            {
                Name = "Количество вычислений целевой функции",
                ParameterType = ParameterType.Output,
                Value = result.FuncEvalsCount,
                DecimalPlaces = 0
            };
            var methodIterationsCount = new Parameter
            {
                Name = "Количество итераций метода",
                ParameterType = ParameterType.Output,
                Value = result.MethodIterationsCount,
                DecimalPlaces = 0
            };
            methodMetrics.AddRange(new[] { elapsedTime, funcEvalsCount, methodIterationsCount });

            var TFMaxValue = new Parameter
            {
                Name = $"Максимальное значение целевой функции ({optimInput.TargetFunc.Name})",
                ParameterType = ParameterType.Output,
                Value = result.TFMaxValue,
                MeasureUnit = optimInput.TargetFunc?.MeasureUnit?.Designation ?? string.Empty
            };
            var FoValue = new Parameter
            {
                Name = $"Значение критериального ограничения ({optimInput.FoFunc.Name})",
                ParameterType = ParameterType.Output,
                Value = result.FoValue,
                MeasureUnit = optimInput.FoFunc?.MeasureUnit?.Designation ?? string.Empty
            };
            var paramsOptimValues = result.ParamsOptimValues.Select(p => new Parameter(p)).ToArray();

            LastOptimResult = new Presenter_Form_Optim_Msg
            {
                ErrorMsg = result.ErrorMsg,
                FValues = result.FValues,
                FoValues = result.FoValues,
                ParamsOptimValues = paramsOptimValues,
                TFMaxValue = TFMaxValue,
                FoValue = FoValue,
                XValuesSolution = result.XValuesSolution,
                MethodMetrics = methodMetrics.ToArray()
            };
            LastOptimRequest = msg;

            return LastOptimResult.Value;
        }
    }
}
