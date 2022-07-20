using Model;
using Researcher.Shared;
using Researcher.View.InterfaceElements.Validation;

namespace Researcher.View.InterfaceElements.ParamsIO
{
    public partial class VariableOrInputParameter : UserControl, IValidatableContainer
    {
        public event Action<VariableOrInputParameter, bool> IsVariableChanged = null!;

        public event Func<VariableOrInputParameter, bool> CanBeVariableRequest = null!;

        public VariableOrInputParameter()
        {
            InitializeComponent();
            ValidatableContainerLogic = new(this);
            ValidatableContainerLogic.AddControl(ParameterInput);

            checkBox.CheckedChanged += CheckBox_CheckedChanged;
        }

        private void ParameterInputWithBounds_Validated(object? sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(parameterInputWithBounds.Value))
                CanBeVariable = false;
            else
                CanBeVariable = CanBeVariableRequest(this);
        }

        private void CheckBox_CheckedChanged(object? sender, EventArgs e)
        {
            if (sender is not CheckBox checkBox)
                return;

            IsVariableChanged(this, checkBox.Checked);
            IsVariable = checkBox.Checked;
        }

        public bool CanBeVariable
        {
            get => checkBox.Enabled;

            set => checkBox.Enabled = value;
        }

        public bool IsVariable
        {
            get => checkBox.Checked;

            set
            {
                checkBox.CheckedChanged -= CheckBox_CheckedChanged;
                checkBox.Checked = value;
                checkBox.CheckedChanged += CheckBox_CheckedChanged;

                if (value is true)
                    ParameterInput.ChangeParamInputType(ParameterType.Output);
                else
                    ParameterInput.ChangeParamInputType(ParameterType.InputEssential);

                ParameterInput.Enabled = !value;
            }
        }

        public VariableParameterInput ParameterInput => parameterInputWithBounds;

        public ValidatableContainerLogic ValidatableContainerLogic { get; }

        public ValidatableControlLogic ValidatableControlLogic => ValidatableContainerLogic;
    }
}