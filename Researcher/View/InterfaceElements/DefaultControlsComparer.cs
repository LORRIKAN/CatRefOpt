using System.Diagnostics.CodeAnalysis;

namespace Researcher.View.InterfaceElements
{
    internal class DefaultControlsComparer : IEqualityComparer<Control>
    {
        public bool Equals(Control? x, Control? y)
        {
            return ReferenceEquals(x, y);
        }

        public int GetHashCode([DisallowNull] Control obj)
        {
            return obj.GetHashCode();
        }
    }
}
