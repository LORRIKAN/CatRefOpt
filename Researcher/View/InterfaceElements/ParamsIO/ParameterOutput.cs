using MatlabBase.Types.Interfaces;
using Researcher.Shared;
using Researcher.View.InterfaceElements.Validation;
using System.ComponentModel;

namespace Researcher.View.InterfaceElements.ParamsIO
{
    public partial class ParameterOutput : UserControl, IValidatableControl
    {
        public ParameterOutput()
        {
            InitializeComponent();
            ValidatableControlLogic = new(this)
            {
                AlwaysValidate = true
            };
            numericUpDown.ValueChanged += NumericUpDown_ValueChanged;
        }

        private void NumericUpDown_ValueChanged(object? sender, EventArgs e)
        {
            UpdateDecimalPlaces((int)numericUpDown.Value);
        }

        private void UpdateDecimalPlaces(int decimalPlaces)
        {
            if (parameter is not null)
            {
                parameter.DecimalPlaces = decimalPlaces;
                Value = parameter.ToString();
            }
        }

        public decimal DecimalPlaces
        {
            get => numericUpDown.Value;
            set
            {
                numericUpDown.Value = value;
                UpdateDecimalPlaces((int)value);
            }
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
            DecimalPlaces = Parameter?.DecimalPlaces ?? 0;

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