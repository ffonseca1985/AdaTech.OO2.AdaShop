using AdaTech.AdaShop.Domain.Contracts;

namespace AdaTech.AdaShop.Domain.Models
{
    //Emploee herda de uma interface IEntity, logo é obrigado a seguir o contrato de IEntity.
    //Ou seja, deve implementar os métodos e propriedade da interface IEntity
    public class Employee : IEntity
    {
        public Employee(string name)
        {
            ID = Guid.NewGuid().ToString();
            Name = name;
        }

        public string ID { get; private set; }
        public string Name { get; private set; }
    }
}