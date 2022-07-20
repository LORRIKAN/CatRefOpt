using Model.CatRef;
using Researcher.Shared;
using Researcher.View.InterfaceElements.ParamsIO;

namespace Researcher.View.InterfaceElements.Panels
{
    public class OptimParamsPanel : TopDownFlowLayoutPanel
    {
        public OptimParamsPanel()
        {
            ControlAdded += ParamsOfOptimMethodPanel_ControlAdded;
        }

        private void ParamsOfOptimMethodPanel_ControlAdded(object? sender, ControlEventArgs e)
        {
            if (e.Control is not VariableParameterInput parameterInput 
                || parameterInput.Parameter is not VariableParameterWithValue parameter
                || parameter.ParameterOfOptimizationMethod is not ParameterOfOptimizationMethod parameterOfOptimizationMethod)
                return;

            parameterInput.ChangeParamInputType(parameterOfOptimizationMethod.IsNecessary ? ParameterType.InputEssential
                : ParameterType.InputOptional);
        }
    }
}
