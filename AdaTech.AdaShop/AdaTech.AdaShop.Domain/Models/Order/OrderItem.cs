using AdaTech.AdaShop.Domain.Contracts;

namespace AdaTech.AdaShop.Domain.Models.Order
{
    public class OrderItem : IEntity
    {
        public OrderItem(Product product, decimal quantity = 1)
        {
            ID = Guid.NewGuid().ToString();
            Product = product;
            Quantity = quantity;
            Price = Product.Price;
        }

        public string ID { get; private set; }
        public decimal Price { get; private set; }
        public Product Product { get; private set; }
        public decimal Quantity {get; private set;}

        public decimal TotalItem 
        { 
            get { 
                return this.Quantity * this.Price; 
            }
        }
    }
}