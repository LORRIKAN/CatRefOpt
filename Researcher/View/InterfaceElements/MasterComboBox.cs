using Researcher.Shared;
using Researcher.View.InterfaceElements.Validation;
using System.ComponentModel;

namespace Researcher.View.InterfaceElements
{
    public class MasterComboBox : ComboBox, IValidatableControl
    {
        [Browsable(false)]
        [ReadOnly(true)]
        public event Func<MasterComboBox, DataSource>? GetDataSource;

        public MasterComboBox()
        {
            ValidatableControlLogic = new(this);
            DropDownStyle = ComboBoxStyle.DropDownList;
            ValidatableControlLogic.ValidationFunc += MasterComboBox_Validating;
        }

        private void MasterComboBox_Validating(IValidatableControl control, CancelEventArgs e)
        {
            e.Cancel = e.Cancel || (InvalidateIfNoItems && Items.Count is 0);
        }

        public void SetDataSource()
        {
            (object? dataSource, string? displayMember, string? valueMember) =
                GetDataSource?.Invoke(this) ?? (null, null, null)!;

            DataSource = dataSource;
            DisplayMember = displayMember;
            ValueMember = valueMember;

            ValidatableControlLogic.TryValidate();
        }

        public bool InvalidateIfNoItems { get; set; } = true;

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
            RearrangeDependentControls();
        }

        public void RearrangeDependentControls()
        {
            RearrangeDependentControls(ControlsAndParams.Keys.ToArray());
            RearrangeDependentControls(ListControls.ToArray());
        }

        public void RearrangeDependentControls(params Control[] controls)
        {
            foreach (var item in controls)
            {
                if (!ControlsAndParams.ContainsKey(item))
                    continue;

                RemoveParamsFromControl(item);
                AddParamsToControl(item);
            }
        }

        public void AddDependentControl(Control control, Func<Control, object?, IEnumerable<Control>> getFunc)
        {
            ControlsAndParams.Add(control, new List<Control>());
            ControlsAndGetFuncs.Add(control, getFunc);
        }

        public void RemoveDependentControl(Control control, bool tryRemoveParams = true)
        {
            if (tryRemoveParams && ControlsAndParams.ContainsKey(control))
                RemoveParamsFromControl(control);

            ControlsAndParams.Remove(control);
            ControlsAndGetFuncs.Remove(control);
        }

        private void AddParamsToControl(Control control)
        {
            Control[] controlsToAdd = ControlsAndGetFuncs[control](control, SelectedItem).ToArray();
            control.Controls.AddRange(controlsToAdd);
            ControlsAndParams[control].AddRange(controlsToAdd);
        }

        private void RemoveParamsFromControl(Control control)
        {
            foreach (var item in ControlsAndParams[control])
                control.Controls.Remove(item);

            ControlsAndParams[control].Clear();
        }

        public void RearrangeDependentControls(params MasterComboBox[] controls)
        {
            foreach (var item in controls)
            {
                if (!ListControls.Contains(item, ControlsEqualityComparer))
                    continue;

                RemoveParamsFromControl(item);
                AddParamsToControl(item);
            }
        }

        public void AddDependentControl(MasterComboBox control)
        {
            ListControls.Add(control);
        }

        public void RemoveDependentControl(MasterComboBox control, bool tryRemoveParams = true)
        {
            if (tryRemoveParams)
                RemoveParamsFromControl(control);

            ListControls.Remove(control);
        }

        private void AddParamsToControl(MasterComboBox control)
        {
            control.SetDataSource();
        }

        private void RemoveParamsFromControl(MasterComboBox control)
        {
            //control.DataSource = null;
        }

        private IEqualityComparer<Control> controlsEqualityComparer = new DefaultControlsComparer();
        [Browsable(false)]
        [ReadOnly(true)]
        public IEqualityComparer<Control> ControlsEqualityComparer
        {
            get => controlsEqualityComparer;
            set
            {
                controlsEqualityComparer = value;
                ControlsAndParams = new Dictionary<Control, List<Control>>(ControlsAndParams, value);
                ControlsAndGetFuncs = new Dictionary<Control, Func<Control, object?, IEnumerable<Control>>>(ControlsAndGetFuncs, value);
            }
        }

        private Dictionary<Control, Func<Control, object?, IEnumerable<Control>>> ControlsAndGetFuncs { get; set; } = 
            new(new DefaultControlsComparer());

        private List<MasterComboBox> ListControls { get; set; } = new();

        private Dictionary<Control, List<Control>> ControlsAndParams { get; set; } = new(new DefaultControlsComparer());

        [Browsable(false)]
        [ReadOnly(true)]
        public ValidatableControlLogic ValidatableControlLogic { get; }
    }
}