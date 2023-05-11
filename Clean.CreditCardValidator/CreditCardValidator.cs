using System.Text.RegularExpressions;

namespace Clean.CreditCardValidator
{
    public static class CreditCardValidator
    {
        public static bool Validate(string creditCard)
        {
            string creditCardRegex = "^\\d{16}";
            return Regex.IsMatch(creditCard, creditCardRegex);
        }
    }
}
