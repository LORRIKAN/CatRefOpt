namespace MatlabBase
{
    public static class MatlabGetter
    {
        public static MLApp.MLApp? Matlab
        {
            get
            {
                if (matlab is null)
                {
                    try
                    {
                        matlab = new MLApp.MLApp
                        {
                            Visible = 0
                        };
                    }
                    catch
                    {
                        matlab = null;
                    }
                }

                return matlab;
            }
        }

        public static void TryCloseMatlab()
        {
            matlab?.Quit();
            matlab = null;
        }

        private static MLApp.MLApp? matlab;
    }
}
