using Model;
using Researcher.Shared;
using Researcher.View.InterfaceElements.Validation;
using System.ComponentModel;

namespace Researcher.View.InterfaceElements.ParamsIO
{
    public partial class ParameterInput : UserControl, IValidatableControl
    {
        public ParameterInput()
        {
            InitializeComponent();
            ValidatableControlLogic = new(this);
            ValidatableControlLogic.ValidationFunc += Logic_ValidationFunc;
            textBox.TextChanged += (_,_) => ValidatableControlLogic.TryValidate();
        }

        private void Logic_ValidationFunc(IValidatableControl validatableControl, CancelEventArgs e)
        {
            ValidateTextBox(e);
        }

        private void ValidateTextBox(CancelEventArgs e)
        {
            if (Parameter?.ParameterType is ParameterType.Output)
            {
                errorProvider.SetError(errorLbl, null);
                return;
            }

            if (string.IsNullOrEmpty(textBox.Text) || string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (Parameter?.ParameterType is not ParameterType.InputEssential)
                {
                    errorProvider.SetError(errorLbl, null);
                    if (Parameter is not null)
                        Parameter.Value = null;
                    return;
                }
                else
                {
                    errorProvider.SetError(errorLbl, "Значение не может быть пустым");
                    e.Cancel = true;
                    return;
                }
            }

            string? errorMsg = Parameter?.TryParseAndSetValue(textBox.Text);
            errorProvider.SetError(errorLbl, errorMsg);

            if (!string.IsNullOrEmpty(errorMsg))
                e.Cancel = true;
        }

        public string Value
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }

        public string ParameterName
        {
            get => paramNameLbl.Text;
            set => paramNameLbl.Text = value;
        }

        public string MeasureUnit
        {
            get => measureUnitLbl.Text;
            set => measureUnitLbl.Text = value;
        }

        public void UpdateWithParameter(bool tryValidate)
        {
            MeasureUnit = Parameter?.MeasureUnit ?? string.Empty;
            ParameterName = Parameter?.Name ?? string.Empty;
            Value = Parameter?.ToString() ?? string.Empty;

            if (tryValidate)
                ValidatableControlLogic.TryValidate();
        }


        private Parameter? parameter;
        [Browsable(false)]
        [ReadOnly(true)]
        public virtual Parameter? Parameter
        {
            get => parameter;
            set
            {
                parameter = value;
                UpdateWithParameter(true);
            }
        }

        public ValidatableControlLogic ValidatableControlLogic { get; }
    }
}