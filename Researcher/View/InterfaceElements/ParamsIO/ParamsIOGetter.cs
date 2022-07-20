using MatlabBase.Types.Interfaces;
using Model;
using Researcher.Shared;

namespace Researcher.View.InterfaceElements.ParamsIO
{
    public static class ParamsIOGetter
    {
        public static IEnumerable<ParameterInput> GetParamsInputs(IEnumerable<Parameter> parameters) =>
            parameters.Select(p => GetParamInput(p));

        private static ParameterInput GetParamInput(Parameter p) => new ParameterInput { Parameter = p, BorderStyle = BorderStyle.FixedSingle };

        public static IEnumerable<ParameterOutput> GetParamsOutputs(IEnumerable<IParameterWithValue> parameters) =>
            parameters.Select(p => GetParamOutput(p));

        public static ParameterOutput GetParamOutput(IParameterWithValue parameter) => 
            new ParameterOutput { Parameter = new Parameter(parameter), BorderStyle = BorderStyle.FixedSingle };

        public static IEnumerable<ParameterOutput> GetParamsOutputs(IEnumerable<Parameter> parameters) =>
            parameters.Select(p => GetParamOutput(p));

        public static ParameterOutput GetParamOutput(Parameter parameter) =>
            new ParameterOutput { Parameter = parameter, BorderStyle = BorderStyle.FixedSingle };

        public static IEnumerable<VariableParameterInput> GetVariableParamsInputs(
            IEnumerable<VariableParameterWithValue> parameters) =>
            parameters.Select(p => GetVariableParamInput(p));

        public static VariableParameterInput GetVariableParamInput(VariableParameterWithValue parameter)
        {
            var param = new VariableParameterInput { Parameter = parameter, BorderStyle = BorderStyle.FixedSingle };
            param.ChangeParamInputType(parameter.ParameterType);
            return param;
        }

        public static IEnumerable<VariableOrInputParameter> GetVariableOrInputParams(
            IEnumerable<VariableParameterWithValue> parameters) =>
            parameters.Select(p => GetVariableOrInputParam(p));

        public static VariableOrInputParameter GetVariableOrInputParam(VariableParameterWithValue parameter)
        {
            var param = new VariableOrInputParameter();
            param.ParameterInput.Parameter = parameter;
            return param;
        }

        public static void ChangeParamInputType(this VariableParameterInput parameter, 
            ParameterType parameterType)
        {
            static void ChangeParamType(VariableParameterInput parameter, ParameterType parameterType)
            {
                if (parameter.Parameter is not null)
                    parameter.Parameter.ParameterType = parameterType;
                parameter.ValidatableControlLogic.TryValidate();
            } 

            switch (parameterType)
            {
                case ParameterType.InputEssential:
                    parameter.ParameterName = parameter.ParameterName.AddIfNotContains("*");
                    ChangeParamType(parameter, parameterType);
                    break;
                case ParameterType.InputOptional:
                    parameter.ParameterName = parameter.ParameterName.Replace("*", "");
                    ChangeParamType(parameter, parameterType);
                    break;
                case ParameterType.Output:
                    parameter.ParameterName = parameter.ParameterName.Replace("*", "");
                    ChangeParamType(parameter, parameterType);
                    break;
                default:
                    break;
            }
        }
    }
}
