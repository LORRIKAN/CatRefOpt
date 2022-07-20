namespace MatlabBase
{
    public static class SharedFuncs
    {
        public static string Path => $"'{System.IO.Path.GetFullPath(@".\")}'";
    }
}