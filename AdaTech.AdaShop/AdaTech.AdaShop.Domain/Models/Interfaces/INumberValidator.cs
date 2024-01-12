namespace AdaTech.AdaShop.Domain.Models.Interfaces
{
    internal interface INumberValidator
    {
        internal static bool IsValid(string numberToValidate, string prompt)
        {
            if (string.IsNullOrEmpty(numberToValidate))
            {
                throw new ArgumentNullException(prompt);
            }
            else if (!numberToValidate.All(char.IsDigit))
            {
                throw new ArgumentException($"O {prompt} só pode ser composto por algarismos numéricos.");
            }
            else
            {
                return true;
            }
        }
    }
}