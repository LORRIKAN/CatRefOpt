using Model;
using Researcher.Shared;
using Researcher.View.InterfaceElements.Validation;
using System.ComponentModel;

namespace Researcher.View.InterfaceElements.ParamsIO
{
    public partial class VariableParameterInput : UserControl, IValidatableContainer
    {
        public VariableParameterInput()
        {
            InitializeComponent();
            ValidatableContainerLogic = new(this);
            ValidatableContainerLogic.AddControl(parameterInput);
        }

        public string ParameterName
        {
            get => parameterInput.ParameterName;
            set => parameterInput.ParameterName = value;
        }

        public string Value
        {
            get => parameterInput.Value;
            set => parameterInput.Value = value;
        }

        public string MeasureUnit
        {
            get => parameterInput.MeasureUnit;
            set => parameterInput.MeasureUnit = value;
        }

        public string LowerBound
        {
            get => lowerBoundLbl.Text;
            set => lowerBoundLbl.Text = value;
        }

        public string UpperBound
        {
            get => upperBoundLbl.Text;
            set => upperBoundLbl.Text = value;
        }

        private bool InnerUpdate { get; set; }

        public void UpdateWithParameter(bool tryValidate)
        {
            if (!InnerUpdate)
                parameterInput.UpdateWithParameter(false);
            LowerBound = Parameter?.LowerBound.ToString("F2") ?? string.Empty;
            UpperBound = Parameter?.UpperBound.ToString("F2") ?? string.Empty;

            if (tryValidate)
                ValidatableControlLogic.TryValidate();
        }

        [Browsable(false)]
        [ReadOnly(true)]
        public VariableParameterWithValue? Parameter
        {
            get => parameterInput.Parameter as VariableParameterWithValue;
            set
            {
                parameterInput.Parameter = value;
                InnerUpdate = true;
                UpdateWithParameter(true);
                InnerUpdate = false;
            }
        }

        public ValidatableControlLogic ValidatableControlLogic => ValidatableContainerLogic;
        public ValidatableContainerLogic ValidatableContainerLogic { get; }
    }
}
