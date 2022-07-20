using Researcher.Shared;
using Researcher.View.InterfaceElements.ParamsIO;

namespace Researcher.View.InterfaceElements.Panels
{
    public class InputParamsPanel : TopDownFlowLayoutPanel
    {
        public InputParamsPanel()
        {
            ControlAdded += InputParamsPanel_ControlAdded;
        }

        private void InputParamsPanel_ControlAdded(object? sender, ControlEventArgs e)
        {
            if (sender is not ParameterInput parameterInput ||
                parameterInput.Parameter is not Parameter parameter)
                return;

            parameter.ParameterType = ParameterType.Output;
        }
    }
}
