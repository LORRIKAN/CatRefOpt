using MatlabBase.Types.Interfaces;

namespace OptimizationMatlab
{
    public readonly struct OptimResult
    {
        public IParameterWithValue[] ParamsOptimValues { get; init; }

        public double TFMaxValue { get; init; }

        public double FoValue { get; init; }

        public int MethodIterationsCount { get; init; }

        public int FuncEvalsCount { get; init; }

        public double? Eps { get; init; }

        public double ElapsedTimeInSec { get; init; }

        public IDictionary<IParameter, double[]> XValuesSolution { get; init; }

        public double[] FValues { get; init; }

        public double[] FoValues { get; init; }

        public string? ErrorMsg { get; init; }
    }
}
