
namespace AdaTech.AdaShop.Domain.Models.Order
{
    using AdaTech.AdaShop.Domain.Contracts;
    using AdaTech.AdaShop.Domain.Models;

    public class OrderAggregate : IEntity
    {
        public OrderAggregate(Customer customer, ShippingCompany shippingCompany)
        {
            this.ID = Guid.NewGuid().ToString();
            this.Customer = customer;
            this.ShippingCompany = shippingCompany;
            this.OrderDate = new DateTime();
        }

        public string ID { get; private set; }
        public List<OrderItem> OrderItem { get; private set; } = new();
        public InfoPayments? InfoPayments { get; private set; }

        //Podemos ter um customer ou não.
        //Pode ser uma venda online ou na loja
        public Customer Customer { get; private set; }

        public decimal Total { 

            get {
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
        public ShippingCompany ShippingCompany { get; private set; }
    }
}
