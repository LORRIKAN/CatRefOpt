using Researcher.Shared;
using Researcher.Shared.Messages.VisOptimMsgs;
using VisualizationMatlab;

namespace Researcher.Presenter
{
    public partial class ResearcherPresenter
    {
        private Build2DPathMsg GetMatlab2DPathMsg(Presenter_Form_Optim_Msg lastOptimResult,
            Form_Presenter_Optim_Msg lastOptimRequest)
        {
            var visMsg = GetMatlabVisMsg(lastOptimRequest);

            var x = lastOptimResult.XValuesSolution.Values.First();
            var y = lastOptimResult.XValuesSolution.Values.Last();
            var optimMethodName = lastOptimRequest.OptimMethod.Name;

            return new Build2DPathMsg
            {
                OptimMethodName = optimMethodName,
                VisMsg = visMsg,
                X = x,
                Y = y
            };
        }

        private Build3DPathMsg GetMatlab3DPathMsg(Presenter_Form_Optim_Msg lastOptimResult,
            Form_Presenter_Optim_Msg lastOptimRequest)
        {
            var visMsg = GetMatlabVisMsg(lastOptimRequest);

            var x = lastOptimResult.XValuesSolution.Values.First();
            var y = lastOptimResult.XValuesSolution.Values.Last();
            var z = lastOptimResult.FValues;
            var optimMethodName = lastOptimRequest.OptimMethod.Name;

            return new Build3DPathMsg
            {
                OptimMethodName = optimMethodName,
                VisMsg = visMsg,
                X = x,
                Y = y,
                Z = z
            };
        }

        private string? Form_BuildPathPlot(bool is3D)
        {
            if (LastOptimRequest is null || LastOptimResult is null)
                return "Сначала проведите процесс оптимизации";

            try
            {
                if (is3D)
                {
                    var z = LastOptimResult.Value.FValues;
                    return VisualizationStarter.Build3DPathPlot(GetMatlab3DPathMsg(LastOptimResult.Value
                        , LastOptimRequest.Value));
                }
                else
                    return VisualizationStarter.Build2DPathPlot(GetMatlab2DPathMsg(LastOptimResult.Value
                        , LastOptimRequest.Value));
            }
            catch (Exception ex) { return ex.Message; }
        }

        private Presenter_Form_BuildTableOfValues_Msg Form_BuildValuesTable(Form_Presenter_BuildTableOfValues_Msg msg)
        {
            var visMsg = GetMatlabVisMsg(msg.VisMsg);

            var tableMsg = new ValuesTableBuildMsg
            {
                VisMsg = visMsg,
                N = msg.N,
                M = msg.M
            };

            var res = VisualizationStarter.BuildValuesTable(tableMsg);

            return new Presenter_Form_BuildTableOfValues_Msg
            {
                ErrorMsg = res.ErrorMsg,
                FuncValues = res.FuncValues,
                YDelta = res.YDelta,
                XDelta = res.XDelta,
                XParam = visMsg.X,
                YParam = visMsg.Y
            };
        }

        private VisMsg GetMatlabVisMsg(Form_Presenter_Optim_Msg msg)
        {
            var empiricalCoeffs = msg.TargetFunc.EmpiricalCoefficients.Select(ef => new Parameter(ef))
                .ToArray();
            var inputParams = msg.ProcessInputParams
                .Concat(msg.Plant.Reactors.SelectMany(r => Form_GetReactorInputParams(r, msg.MathModel)))
                .Concat(Form_GetMaterialInputParams(msg.Material, msg.MathModel))
                .Concat(Form_GetCatalystInputParams(msg.Catalyst, msg.MathModel)).ToArray();

            return new VisMsg
            {
                X = msg.VariableParams.First(),
                Y = msg.VariableParams.Last(),
                InputParams = inputParams,
                EmpiricalCoeffs = empiricalCoeffs,
                TargetFunc = msg.TargetFunc,
            };
        }

        private VisMsg GetMatlabVisMsg(Form_Presenter_Vis_Msg msg)
        {
            var empiricalCoeffs = msg.TargetFunc.EmpiricalCoefficients.Select(ef => new Parameter(ef))
                .ToArray();
            var inputParams = msg.ProcessInputParams
                .Concat(msg.Plant.Reactors.SelectMany(r => Form_GetReactorInputParams(r, msg.MathModel)))
                .Concat(Form_GetMaterialInputParams(msg.Material, msg.MathModel))
                .Concat(Form_GetCatalystInputParams(msg.Catalyst, msg.MathModel)).ToArray();

            return new VisMsg
            {
                X = msg.VariableParams.First(),
                Y = msg.VariableParams.Last(),
                InputParams = inputParams,
                EmpiricalCoeffs = empiricalCoeffs,
                TargetFunc = msg.TargetFunc,
            };
        }

        private string? Form_StartVisualization(Form_Presenter_BuildPlot_Msg msg)
        {
            var visMsg = GetMatlabVisMsg(msg.VisMsg);
            var plotMsg = new BuildPlotMsg
            {
                VisMsg = visMsg,
                Is3D = msg.Is3D
            };

            try
            {
                return VisualizationStarter.BuildPlot(plotMsg);
            }
            catch (Exception ex) { return ex.Message; }
        }
    }
}
