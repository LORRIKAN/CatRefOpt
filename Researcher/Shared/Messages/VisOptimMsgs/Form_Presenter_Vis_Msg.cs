using Model.CatRef;

namespace Researcher.Shared.Messages.VisOptimMsgs
{
    public readonly struct Form_Presenter_Vis_Msg
    {
        public Plant Plant { get; init; }

        public Material Material { get; init; }

        public Catalyst Catalyst { get; init; }

        public VariableParameterWithValue[] VariableParams { get; init; }

        public VariableParameterWithValue[] ProcessInputParams { get; init; }

        public MatlabFunc TargetFunc { get; init; }

        public MatlabMathModel MathModel { get; init; }
    }
}
