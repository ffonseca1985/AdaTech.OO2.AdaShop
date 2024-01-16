using AdaTech.AdaShop.Domain.Contracts;

namespace AdaTech.AdaShop.Domain.Models
{
    public class Customer : IEntity
    {
        public Customer(string name)
        {
            ID = Guid.NewGuid().ToString(); //Guid Tem um algoritmo Matemático que não se repete.
            Name = name;
        }

        public string ID { get; private set; }
        public string Name { get; private set; }

        public void Edit(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("Name is empty");

            this.Name = name;
        }
    }
}