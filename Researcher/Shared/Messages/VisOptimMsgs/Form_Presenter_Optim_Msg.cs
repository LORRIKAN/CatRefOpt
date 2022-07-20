using Model.CatRef;

namespace Researcher.Shared.Messages.VisOptimMsgs
{
    public readonly struct Form_Presenter_Optim_Msg
    {
        public Plant Plant { get; init; }

        public Material Material { get; init; }

        public Catalyst Catalyst { get; init; }

        public VariableParameterWithValue[] VariableParams { get; init; }

        public VariableParameterWithValue[] ProcessInputParams { get; init; }

        public Parameter[] ParamsOfOptimMethod { get; init; }

        public MatlabOptimizationMethod OptimMethod { get; init; }

        public MatlabMathModel MathModel { get; init; }

        public MatlabFunc TargetFunc { get; init; }

        public MatlabFunc FoFunc { get; init; }

        public double Fo { get; init; }

    }
}
