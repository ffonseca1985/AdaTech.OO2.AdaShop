using AdaTech.AdaShop.Domain.Contracts;
using AdaTech.AdaShop.Domain.Models.Order;

namespace AdaTech.AdaShop.Domain.Models.ShippingCompany
{
    public class CorreiosShippingCompany : Contracts.ShippingCompany
    {
        public CorreiosShippingCompany() : base(id: Guid.NewGuid().ToString()) {}

        public override decimal CalculeShipping(OrderAggregate order)
        {
            throw new NotImplementedException();
        }
    }
}
