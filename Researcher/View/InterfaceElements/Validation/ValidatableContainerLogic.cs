using System.ComponentModel;

namespace Researcher.View.InterfaceElements.Validation
{

    public class ValidatableContainerLogic : ValidatableControlLogic
    {
        private List<IValidatableControl> Items { get; } = new();

        private long InvalidatedControlsCount { get; set; }

        public ValidatableContainerLogic(IValidatableControl validatableControl) : base(validatableControl)
        {
            ValidationFunc += Validate;
        }

        public void AddControlsRange(params IValidatableControl[] items)
        {
            foreach (var item in items)
                AddControl(item);
        }

        public void AddControl(IValidatableControl item)
        {
            if (!item.ValidatableControlLogic.Validated)
                InvalidatedControlsCount++;

            item.ValidatableControlLogic.ValidatedChanged += Item_ValidatedChanged;
            Items.Add(item);
            TryValidate();
        }

        public void RemoveControlsRange(params IValidatableControl[] items)
        {
            foreach (var item in items)
                RemoveControl(item);
        }

        public void RemoveControl(IValidatableControl item)
        {
            item.ValidatableControlLogic.ValidatedChanged -= Item_ValidatedChanged;

            if (Items.Contains(item) && !item.ValidatableControlLogic.Validated)
                InvalidatedControlsCount--;

            Items.Remove(item);
            TryValidate();
        }

        private void Item_ValidatedChanged(IValidatableControl validatableControl)
        {
            if (!validatableControl.ValidatableControlLogic.Validated)
                InvalidatedControlsCount++;
            else
                InvalidatedControlsCount--;

            TryValidate();
        }

        private void Validate(IValidatableControl validatableControl, CancelEventArgs eventArgs)
        {
            if (eventArgs.Cancel)
                return;

            foreach (var item in Items)
            {
                if (!item.ValidatableControlLogic.TryValidate())
                {
                    eventArgs.Cancel = true;
                    break;
                }
            }
        }
    }
}
