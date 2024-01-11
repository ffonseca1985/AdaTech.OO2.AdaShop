using AdaTech.AdaShop.Domain.Models.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.AdaShop.Domain.Contracts
{
    //User herda de uma interface IEntity, logo é obrigado a seguir o contrato de IEntity.
    //Ou seja, deve implementar os métodos e propriedade da interface IEntity
    public abstract class User : IEntity
    {
        private string cpf;

        public string ID { get; private set; }
        public string Name { get; set; }
        public string CPF
        {
            get { return cpf; }
            private set
            {
                if (value.Length != 11)
                {
                    throw new ArgumentException("CPF inválido");
                }
                else
                {
                    CPF = value;
                }
            }
        }
        internal Address UserAddress { get; set; }
    }
}
