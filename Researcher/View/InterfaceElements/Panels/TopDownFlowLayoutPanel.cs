using Researcher.View.InterfaceElements.Validation;

namespace Researcher.View.InterfaceElements.Panels
{
    public class TopDownFlowLayoutPanel : FlowLayoutPanel, IValidatableContainer
    {

        public TopDownFlowLayoutPanel()
        {
            ValidatableContainerLogic = new(this);
            FlowDirection = FlowDirection.TopDown;
            AutoScroll = true;
            WrapContents = false;
            ControlAdded += TopDownFlowLayoutPanel_ControlAdded;
            ControlRemoved += TopDownFlowLayoutPanel_ControlRemoved;
            SizeChanged += TopDownFlowLayoutPanel_SizeChanged;
        }

        private void TopDownFlowLayoutPanel_ControlRemoved(object? sender, ControlEventArgs e)
        {
            if (e.Control is IValidatableControl validatable)
                ValidatableContainerLogic.RemoveControl(validatable);
        }

        private void TopDownFlowLayoutPanel_ControlAdded(object? sender, ControlEventArgs e)
        {
            if (Controls.Count is 1)
            {
                e.Control.Dock = DockStyle.None;
                Controls[0].Width = DisplayRectangle.Width - Controls[0].Margin.Horizontal;
            }
            else
                e.Control.Dock = DockStyle.Top;

            if (e.Control is IValidatableControl validatable)
                ValidatableContainerLogic.AddControl(validatable);
        }

        private void TopDownFlowLayoutPanel_SizeChanged(object? sender, EventArgs e)
        {
            if (Controls.Count is 0 || FlowDirection is not FlowDirection.TopDown)
                return;

            Controls[0].Width = DisplayRectangle.Width - Controls[0].Margin.Horizontal;
        }

        public ValidatableContainerLogic ValidatableContainerLogic { get; }

        public ValidatableControlLogic ValidatableControlLogic => ValidatableContainerLogic;
    }
}
