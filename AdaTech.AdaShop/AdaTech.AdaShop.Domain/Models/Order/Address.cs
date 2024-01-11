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
        private string rua;
        private string bairro;
        private string cidade;
        private string estado;
        private string cep;
        private int numero;
        private string completmento;

        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep
        {
            get { return cep; }
            set
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
        public int Numero { get; set; }
        public string Complemento { get; set; }




    }
}
