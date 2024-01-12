using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.AdaShop.Domain.Models.Order
{
    internal class Address
    {
        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Neighborhood { get; private set; }
        public string Complement { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Cep
        {
            get { return Cep; }
            private set
            {
                if(value.Length != 8) 
                {
                    throw new ArgumentException("Cep inválido");
                }
                else
                {
                    Cep = value;
                }
            }
        }

        public Address(string street, string number, string complement, string neighborhood, string city, string state, string cep)
        {
            Street = street;
            Cep = cep;
            Number = number;
            Complement = complement;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Cep = cep;
        }
    }
}
