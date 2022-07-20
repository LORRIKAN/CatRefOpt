using Researcher.Shared;
using Researcher.View.InterfaceElements.ParamsIO;

namespace Researcher.View.InterfaceElements.Panels
{
    public class StartingPointPanel : TopDownFlowLayoutPanel
    {
        public StartingPointPanel()
        {
            ControlAdded += StartingPointPanel_ControlAdded;
        }

        private void StartingPointPanel_ControlAdded(object? sender, ControlEventArgs e)
        {
            if (e.Control is not VariableParameterInput parameterInput
                || parameterInput.Parameter is not VariableParameterWithValue parameter)
                return;

            parameter.Value = (parameter.LowerBound + parameter.UpperBound) / 2;
            parameterInput.UpdateWithParameter(true);
        }
    }
}
