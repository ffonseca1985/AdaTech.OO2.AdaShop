using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.AdaShop.Domain.Models.Validators
{ 
    internal interface INumberValidator<T>
    {
        bool IsNumberValid(T numberToValidate, string prompt);
    }
}
