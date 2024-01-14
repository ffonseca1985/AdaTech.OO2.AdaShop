using AdaTech.AdaShop.Domain.Contracts;

namespace AdaTech.AdaShop.Domain.Models
{
    public class Product : IEntity
    {
        public Product(string name, decimal price)
        {
            ID = Guid.NewGuid().ToString();
            Name = name;
            Price = price;
        }

        public string ID { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
    }
}