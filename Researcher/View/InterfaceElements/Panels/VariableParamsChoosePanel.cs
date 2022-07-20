using Model;
using Researcher.Shared;
using Researcher.View.InterfaceElements.ParamsIO;

namespace Researcher.View.InterfaceElements.Panels
{
    public class VariableParamsChoosePanel : TopDownFlowLayoutPanel
    {
        public event Action<VariableParamsChoosePanel>? VariableParamsCountChanged;
        public VariableParamsChoosePanel()
        {
            ControlAdded += VariableOrInputParametersLayoutPanel_ControlAdded;
            ControlRemoved += VariableOrInputParametersLayoutPanel_ControlRemoved;
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            ValidatableControlLogic.AlwaysValidate = Enabled;
            base.OnEnabledChanged(e);
        }

        private void VariableOrInputParametersLayoutPanel_ControlRemoved(object? sender, ControlEventArgs e)
        {
            if (e.Control is not VariableOrInputParameter param)
                return;

            param.IsVariableChanged -= Param_IsVariableChanged;
            param.CanBeVariableRequest -= Param_CanBeVariableRequest;
            if (param.IsVariable)
                CurrVariableParams--;
        }

        private void VariableOrInputParametersLayoutPanel_ControlAdded(object? sender, ControlEventArgs e)
        {
            if (e.Control is not VariableOrInputParameter param)
                return;

            param.IsVariableChanged += Param_IsVariableChanged;
            param.CanBeVariableRequest += Param_CanBeVariableRequest;

            if (CurrVariableParams < MaxVariableParams)
            {
                param.CanBeVariable = true;
                param.IsVariable = true;

                CurrVariableParams++;
            }
            else
            {
                param.CanBeVariable = false;
                param.IsVariable = false;
            }
        }

        public IEnumerable<VariableParameterWithValue?> VariableParams => GetParametersOfType(true);

        public IEnumerable<VariableParameterWithValue?> InputParams => GetParametersOfType(false);

        public long MaxVariableParams { get; set; } = long.MaxValue;

        private long currVariableParams;
        public long CurrVariableParams
        {
            get => currVariableParams;
            private set
            {
                currVariableParams = value;

                VariableParamsCountChanged?.Invoke(this);
            }
        }

        private IEnumerable<VariableParameterWithValue?> GetParametersOfType(bool isVariable)
        {
            foreach (VariableOrInputParameter item in Controls.OfType<VariableOrInputParameter>())
                if (item.IsVariable == isVariable)
                    yield return item.ParameterInput.Parameter;
        }

        private bool Param_CanBeVariableRequest(VariableOrInputParameter _)
        {
            return CurrVariableParams < MaxVariableParams;
        }

        private void Param_IsVariableChanged(VariableOrInputParameter param, bool isVariable)
        {
            if (isVariable)
                CurrVariableParams++;
            else
                CurrVariableParams--;

            bool canBeVariable = CurrVariableParams < MaxVariableParams;

            foreach (VariableOrInputParameter visParam in Controls.OfType<VariableOrInputParameter>()
                .Where(p => !p.IsVariable))
                visParam.CanBeVariable = canBeVariable;
        }
    }
}