using AdaTech.AdaShop.Domain.Contracts;

namespace AdaTech.AdaShop.Domain.Models
{
    //Emploee herda de uma interface IEntity, logo é obrigado a seguir o contrato de IEntity.
    //Ou seja, deve implementar os métodos e propriedade da interface IEntity
    public class Employee : IEntity
    {
        public string ID { get; private set; }
    }
}