using AdaTech.AdaShop.Domain.Models.Order;

namespace AdaTech.AdaShop.Domain.Models.ShippingCompany
{
    public class JadLogShippingCompany : Contracts.ShippingCompany
    {
        public JadLogShippingCompany() : base(id: Guid.NewGuid().ToString()) { }

        public override decimal CalculeShipping(OrderAggregate order)
        {
            throw new NotImplementedException();
        }
    }
}
