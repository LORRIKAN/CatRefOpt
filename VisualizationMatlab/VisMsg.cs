using MatlabBase.Types.Interfaces;
using Model.CatRef;

namespace VisualizationMatlab
{
    public readonly struct VisMsg
    {
        public IVariableParameter X { get; init; }

        public IVariableParameter Y { get; init; }

        public IParameterWithValue[] InputParams { get; init; }

        public IParameterWithValue[] EmpiricalCoeffs { get; init; }

        public MatlabFunc TargetFunc { get; init; }
    }
}
