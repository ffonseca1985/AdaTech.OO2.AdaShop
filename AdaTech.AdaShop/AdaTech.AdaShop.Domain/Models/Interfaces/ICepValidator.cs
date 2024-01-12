using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.AdaShop.Domain.Models.Interfaces
{
    internal interface ICepValidator
    {
        internal static bool IsValid(string cepToValidate) {
            if(string.IsNullOrEmpty(cepToValidate))
            {
                throw new ArgumentNullException("O cep não pode ser vazio ou nulo.");
            } else if(cepToValidate.Length != 8)
            {
                throw new ArgumentException("O cep deve ter 8 caracteres.");
            } else if(!cepToValidate.All(char.IsDigit))
            {
                throw new ArgumentException("O cep só pode ser composto por algarismos numéricos.");
            } else
            {
                return true;
            }
        }
    }
}
