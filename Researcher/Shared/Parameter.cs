using MatlabBase.Types.Interfaces;
using Model.CatRef;
using Researcher.View.InterfaceElements.ParamsIO.NumericsValidation;

namespace Researcher.Shared
{
    public class Parameter : IPrototype<Parameter>, IParameterWithValue
    {
        public event Action<Parameter>? ValueChanged;
        public Parameter(MaterialParameter materialParameter)
        {
            Name = materialParameter.Name;
            Designation = materialParameter.Designation;
            Value = materialParameter.Value;
            MeasureUnit = materialParameter.MeasureUnit?.Designation ?? string.Empty;
        }

        public Parameter(CatalystParameter catalystParameter)
        {
            Name = catalystParameter.Name;
            Designation = catalystParameter.Designation;
            Value = catalystParameter.Value;
            MeasureUnit = catalystParameter.MeasureUnit?.Designation ?? string.Empty;

        }

        public Parameter(ReactorParameter reactorParameter)
        {
            Name = reactorParameter.Name;
            Designation = reactorParameter.Designation;
            Value = reactorParameter.Value;
            MeasureUnit = reactorParameter.MeasureUnit?.Designation ?? string.Empty;
        }

        public Parameter(EmpiricalCoefficient empiricalCoefficient)
        {
            Designation = empiricalCoefficient.Designation;
            Value = empiricalCoefficient.Value;
        }

        protected Parameter(OptimizationParameter optimizationParameter)
        {
            Name = optimizationParameter.Name;
            MeasureUnit = optimizationParameter.MeasureUnit?.Designation ?? string.Empty;
        }

        public Parameter(IParameterWithValue parameter)
        {
            InitializeWithIParameter(parameter);
            Value = parameter.Value;
        }

        public Parameter(IParameter parameter)
        {
            InitializeWithIParameter(parameter);
        }

        private void InitializeWithIParameter(IParameter parameter)
        {
            Name = parameter.Name;
            MeasureUnit = parameter.MeasureUnit;
            Designation = parameter.Designation;
        }

        public Parameter()
        {
        }

        public string Name { get; set; } = string.Empty;

        public string MeasureUnit { get; set; } = string.Empty;

        private double? val;
        public double? Value
        {
            get => val;
            set
            {
                val = value;
                ValueChanged?.Invoke(this);
            }
        }
        public string Designation { get; set; } = string.Empty;

        public int DecimalPlaces { get; set; } = 2;

        public bool ChangeDecimalPlacesWhenValueParsed { get; set; } = true;

        public ParameterType ParameterType { get; set; }

        public ParseAndCheckConditions ParseAndCheckConditions { get; set; } = new(
            DoubleParseAndCheckConditions.Parse, DoubleParseAndCheckConditions.MoreThanZero);
        double IParameterWithValue.Value { get => Value!.Value; set => Value = value; }

        public virtual string? TryParseAndSetValue(string value)
        {
            (double result, string? errorMsg) = ParseAndCheckConditions.TryParseAndValidate(value);

            if (string.IsNullOrEmpty(errorMsg))
            {
                if (ChangeDecimalPlacesWhenValueParsed)
                {
                    DecimalPlaces = value.SkipWhile(x => x is not ('.' or ',')).Count() - 1;
                }

                Value = result;
            }

            return errorMsg;
        }

        public string ToString(double val)
        {
            return ToStringInternal(val);
        }

        public override string ToString()
        {
            return ToStringInternal(Value);
        }

        private string ToStringInternal(double? val)
        {
            return val?.ToString($"F{(DecimalPlaces > 0 ? DecimalPlaces : 0)}") ?? string.Empty;
        }

        public virtual Parameter Copy()
        {
            return (Parameter)MemberwiseClone();
        }
    }

    public enum ParameterType
    {
        InputEssential,
        InputOptional,
        Output
    }
}
