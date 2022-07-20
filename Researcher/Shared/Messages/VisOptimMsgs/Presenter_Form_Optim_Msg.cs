using MatlabBase.Types.Interfaces;
using Model.CatRef;
using Researcher.View.InterfaceElements.ParamsIO;

namespace Researcher.Shared.Messages.VisOptimMsgs
{
    public readonly struct Presenter_Form_Optim_Msg
    {
        public Parameter[] ParamsOptimValues { get; init; }

        public Parameter TFMaxValue { get; init; }

        public Parameter FoValue { get; init; }

        public Parameter[] MethodMetrics { get; init; }

        public IDictionary<IParameter, double[]> XValuesSolution { get; init; }

        public double[] FValues { get; init; }

        public double[] FoValues { get; init; }

        public string? ErrorMsg { get; init; }
    }
}
