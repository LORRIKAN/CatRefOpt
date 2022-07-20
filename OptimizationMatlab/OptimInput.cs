using MatlabBase.Types.Interfaces;
using Model.CatRef;

namespace OptimizationMatlab
{
    public readonly struct OptimInput
    {
        public IVariableParameterWithValue[] VariableParams { get; init; }

        public IParameterWithValue[] InputParams { get; init; }

        public IParameterWithValue[] EmpiricalCoefficients { get; init; }

        public IParameterWithValue[] ParamsOfOptimMethod { get; init; }

        public MatlabFunc TargetFunc { get; init; }

        public MatlabOptimizationMethod OptimMethod { get; init; }

        public MatlabFunc FoFunc { get; init; }

        public double Fo { get; init; }
    }
}
