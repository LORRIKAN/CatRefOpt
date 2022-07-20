using MatlabBase.Types.Interfaces;
using Model.CatRef;
using Researcher.View.InterfaceElements.ParamsIO.NumericsValidation;

namespace Researcher.Shared
{
    public class VariableParameterWithValue : Parameter, IVariableParameterWithValue
    {
        public VariableParameterWithValue(VariableParameter variableParameter)
        {
            Name = variableParameter.Name;
            Designation = variableParameter.Designation;

            LowerBound = variableParameter.LowerBound;
            UpperBound = variableParameter.UpperBound;

            VariableParameter = variableParameter;
            MeasureUnit = variableParameter?.MeasureUnit?.Designation ?? string.Empty;

            SetParseAndCheckConditions();
        }

        public VariableParameterWithValue(ParameterOfOptimizationMethod parameterOfOptimizationMethod)
            : base(parameterOfOptimizationMethod.ParameterInfo)
        {
            Designation = parameterOfOptimizationMethod.Designation;

            LowerBound = parameterOfOptimizationMethod.LowerBound;
            UpperBound = parameterOfOptimizationMethod.UpperBound;

            ParseAndCheckConditions = parameterOfOptimizationMethod.IsInt
                ? new(IntParseAndCheckConditions.Parse, IsInBounds)
                : new(DoubleParseAndCheckConditions.Parse, IsInBounds);

            ParameterOfOptimizationMethod = parameterOfOptimizationMethod;
            ParameterType = parameterOfOptimizationMethod.IsNecessary ? ParameterType.InputEssential
                : ParameterType.InputOptional;

            SetParseAndCheckConditions();
        }

        private void SetParseAndCheckConditions()
        {
            ParseAndCheckConditions = new(DoubleParseAndCheckConditions.Parse, IsInBounds);
        }

        public VariableParameterWithValue()
        {
            SetParseAndCheckConditions();
        }

        public VariableParameter? VariableParameter { get; protected set; }

        public ParameterOfOptimizationMethod? ParameterOfOptimizationMethod { get; protected set; }

        public double LowerBound { get; set; } = double.NegativeInfinity;

        public double UpperBound { get; set; } = double.PositiveInfinity;

        public string? IsInBounds(double val)
        {
            if (val < LowerBound)
                return $"Значение не может быть меньше {LowerBound}";
            if (val > UpperBound)
                return $"Значение не может быть больше {UpperBound}";

            return null;
        }

        public override VariableParameterWithValue Copy()
        {
            return (VariableParameterWithValue)MemberwiseClone();
        }
    }
}
