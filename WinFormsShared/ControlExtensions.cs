namespace WinFormsShared
{
    public static class ControlExtensions
    {
        public static T? GetParentControlOfType<T>(this Control control)
        {
            if (control.Parent is T parent)
                return parent;
            else if (control.Parent is null)
                return default;
            else
                return control.Parent.GetParentControlOfType<T>();
        }
    }
}
