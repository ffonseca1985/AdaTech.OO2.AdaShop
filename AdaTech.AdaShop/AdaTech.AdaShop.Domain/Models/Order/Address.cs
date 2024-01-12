using AdaTech.AdaShop.Domain.Models.Validators;
using System;

namespace AdaTech.AdaShop.Domain.Models.Order
{
    public class Address : ICepValidator
    {
        private readonly NumberValidator<string> numberValidator = new NumberValidator<string>();

        private string _cep;
        private string _number;
        public string Street { get; private set; }
        public string Number
        {
            get { return _number; }
            private set
            {
                if (numberValidator.IsNumberValid(value, "Número"))
                {
                    _number = value;
                }
            }
        }

        public string Neighborhood { get; private set; }
        public string Complement { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }

        public string Cep
        {
            get { return _cep; }
            private set
            {
                if (ICepValidator.IsCepValid(value))
                {
                    _cep = value;
                }
            }
        }

        public Address(string street, string number, string complement, string neighborhood, string city, string state, string cep)
        {
            Street = street;
            Number = number;
            Complement = complement;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Cep = cep;
        }
    }
}
