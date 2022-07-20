namespace Researcher.View.InterfaceElements.ParamsIO.NumericsValidation
{
    public static class IntParseAndCheckConditions
    {
        public static (double parsedValue, string? errorMessage) Parse(string stringToParseAndValidate)
        {
            try
            {
                int parsedValue = int.Parse(stringToParseAndValidate);
                return (parsedValue, null);
            }
            catch
            {
                return (0, "Заданное значение не является целочисленным.");
            }
        }
    }
}
