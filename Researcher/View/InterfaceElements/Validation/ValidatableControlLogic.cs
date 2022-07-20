using System.ComponentModel;

namespace Researcher.View.InterfaceElements.Validation
{
    public class ValidatableControlLogic
    {
        public ValidatableControlLogic(IValidatableControl validatableControl)
        {
            ValidatableControl = validatableControl;
        }

        public IValidatableControl ValidatableControl { get; protected set; }

        private bool alwaysValidate = false;

        public bool AlwaysValidate 
        { 
            get => alwaysValidate; 
            set
            {
                alwaysValidate = value;
                TryValidate();
            }
        }

        private bool validated;

        public bool Validated
        {
            get => NoValidationTries switch
            {
                true => TryValidate(),
                _ => validated
            };
            protected set => validated = value;
        }

        public bool NoValidationTries { get; protected set; } = true;

        public event Action<IValidatableControl>? ValidatedChanged;

        public event Action<IValidatableControl, CancelEventArgs>? ValidationFunc;

        public virtual bool TryValidate()
        {
            NoValidationTries = false;
            if (ValidationFunc is null)
                return true;

            bool validated;
            if (AlwaysValidate)
                validated = true;
            else
            {
                var cancelEventArgs = new CancelEventArgs();
                ValidationFunc(ValidatableControl, cancelEventArgs);
                validated = !cancelEventArgs.Cancel;
            }

            TrySetValidatedAndFireChangedEvent(validated, ValidatableControl);

            return validated;
        }

        private void TrySetValidatedAndFireChangedEvent(bool validated,
            IValidatableControl validatableControl)
        {
            if (validated != Validated)
            {
                Validated = validated;
                ValidatedChanged?.Invoke(validatableControl);
            }
        }
    }
}
