
namespace AdaTech.AdaShop.Domain.Models.ShippingCompany
{
    using AdaTech.AdaShop.Domain.Contracts;
    using AdaTech.AdaShop.Domain.Models.Order;

    public class UberShippingCompany : ShippingCompany
    {
        public UberShippingCompany() : base(id: Guid.NewGuid().ToString()) { }

        public override decimal CalculeShipping(OrderAggregate order)
        {
            throw new NotImplementedException();
        }
    }
}
