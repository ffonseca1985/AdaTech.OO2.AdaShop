
using AdaTech.AdaShop.Domain.Models.Validators;

internal interface ICepValidator 
{
    internal static bool IsCepValid(string cepToValidate)
    {
        var validator = new NumberValidator<object>();

        if (validator.IsNumberValid(cepToValidate, "Cep"))
        {
            return IsCepCorrectLength(cepToValidate);
        }
        else
        {
            throw new Exception("Erro desconhecido: a validação do Cep falhou.");
        }
    }

    internal static bool IsCepCorrectLength(string cepToValidate)
    {
        if (cepToValidate.Length != 8)
        {
            throw new ArgumentException("O cep deve ter 8 caracteres.");
        }
        else
        {
            return true;
        }
    }
}