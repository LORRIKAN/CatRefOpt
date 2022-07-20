namespace Researcher.View.InterfaceElements.ParamsIO.NumericsValidation
{
    public class ParseAndCheckConditions
    {
        public ParseAndCheckConditions(Func<string, (double result, string? errorMsg)> parseFunc,
            params Func<double, string?>[] checkFuncs)
        {
            ParseFunc = parseFunc;
            CheckFuncs = new(checkFuncs);
        }

        public Func<string, (double result, string? errorMsg)> ParseFunc { get; set; }

        public HashSet<Func<double, string?>> CheckFuncs { get; set; }

        public (double result, string? errorMessage) TryParseAndValidate(string str)
        {
            (double parsedValue, string? errorMsg) = ParseFunc(str);

            if (!string.IsNullOrEmpty(errorMsg))
            {
                return (parsedValue, errorMsg);
            }

            foreach (Func<double, string?> condition in CheckFuncs)
            {
                errorMsg = condition(parsedValue);

                if (!string.IsNullOrEmpty(errorMsg))
                    return (parsedValue, errorMsg);
            }

            return (parsedValue, null);
        }
    }
}
