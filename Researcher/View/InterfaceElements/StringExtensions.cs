namespace Researcher.View.InterfaceElements
{
    internal static class StringExtensions
    {
        public static string AddIfNotContains(this string str, string strToAdd)
        {
            if (!str.Contains(strToAdd))
                return str + strToAdd;

            return str;
        }
    }
}
