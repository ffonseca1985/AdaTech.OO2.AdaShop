
namespace AdaTech.AdaShop.Domain.Models.Order
{
    using AdaTech.AdaShop.Domain.Contracts;
    using AdaTech.AdaShop.Domain.Models;

    public class OrderAggregate : IEntity
    {
        public OrderAggregate(Customer customer, ShippingCompany shippingCompany, InfoPayments infoPayments)
        {
            this.ID = Guid.NewGuid().ToString();
            this.Customer = customer;
            this.ShippingCompany = shippingCompany;
            this.InfoPayments = infoPayments;
            this.OrderDate = new DateTime();
        }

        public void AddItem(Product product, decimal quantity)
        {
            if (product == null) throw new ArgumentException("Product not found");
            if (quantity <= 0 ) throw new ArgumentException("Invalid Quantity");

            this.OrderItem.Add(new OrderItem(product, quantity));
        }

        public string ID { get; private set; }
        public List<OrderItem> OrderItem { get; private set; } = new();
        public InfoPayments? InfoPayments { get; private set; }

        //Podemos ter um customer ou não.
        //Pode ser uma venda online ou na loja
        public Customer Customer { get; private set; }

        public decimal Total
        {
            get
            {
                if (ShippingCompany == null)
                {
                    return this.OrderItem.Sum(x => x.TotalItem);
                }

                return this.OrderItem.Sum(x => x.TotalItem) + ShippingCompany.CalculeShipping(this);
            }
        }
        public DateTime OrderDate { get; private set; }
        public DateTime ModifyDate { get; private set; }
        public Employee? Employee { get; private set; }

        //Nota-se que ShippingCompany é uma abstração porque queremos usar o OCP
        public ShippingCompany ShippingCompany { get; private set; }
    }
}
