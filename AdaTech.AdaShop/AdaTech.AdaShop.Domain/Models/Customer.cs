using AdaTech.AdaShop.Domain.Contracts;

namespace AdaTech.AdaShop.Domain.Models
{
    public class Customer : IEntity
    {
        public Customer(string name)
        {
            ID = Guid.NewGuid().ToString();
            Name = name;
        }

        public string ID { get; private set; }
        public string Name { get; private set; }
    }
}