namespace Researcher.View.InterfaceElements.ParamsIO.NumericsValidation
{
    public static class DoubleParseAndCheckConditions
    {

        public static (double parsedValue, string? errorMessage) Parse(string stringToParseAndValidate)
        {
            try
            {
                stringToParseAndValidate = stringToParseAndValidate.Replace('.', ',');
                double parsedValue = double.Parse(stringToParseAndValidate);
                return (parsedValue, null);
            }
            catch
            {
                return (0, "Заданное значение не дробное");
            }
        }

        public static string? NotLessThanZero(double val)
        {
            if (val < 0)
                return "Значение не может быть меньше нуля";
            else
                return null;
        }

        public static string? MoreThanZero(double val)
        {
            if (val <= 0)
                return "Значение должно быть строго больше нуля";
            else
                return null;
        }
    }
}
