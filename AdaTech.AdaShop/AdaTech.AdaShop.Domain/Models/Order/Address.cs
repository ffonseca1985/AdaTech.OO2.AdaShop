using AdaTech.AdaShop.Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.AdaShop.Domain.Models.Order
{
    public class Address : ICepValidator, INumberValidator
    {
        private string _cep;
        public string Street { get; private set; }
        public string Number { get; private set; }
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
