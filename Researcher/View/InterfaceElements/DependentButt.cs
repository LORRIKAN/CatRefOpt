using Researcher.View.InterfaceElements.Validation;

namespace Researcher.View.InterfaceElements
{
    public class DependentButt : Button, IValidatableContainer
    {
        public DependentButt()
        {
            ValidatableContainerLogic = new(this);
            ValidatableContainerLogic.ValidatedChanged += ContainerLogic_ValidatedChanged;
        }

        private void ContainerLogic_ValidatedChanged(IValidatableControl control)
        {
            Enabled = control.ValidatableControlLogic.Validated;
        }

        public ValidatableContainerLogic ValidatableContainerLogic { get; }
        public ValidatableControlLogic ValidatableControlLogic => ValidatableContainerLogic;
    }
}
