using System;

namespace AdaTech.AdaShop.Domain.Models.Validators
{
    public class NumberValidator<T> : INumberValidator<T>
    {
        public bool IsNumberValid(T numberToValidate, string prompt)
        {
            if (numberToValidate == null || string.IsNullOrEmpty(numberToValidate.ToString()))
            {
                throw new ArgumentNullException($"{prompt}");
            }
            else if (!numberToValidate.ToString().All(char.IsDigit))
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
