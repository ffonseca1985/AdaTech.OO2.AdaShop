
namespace AdaTech.AdaShop.Application.Order.Commands
{
    public class AddOrderCommand
    {
        public string CustomerId { get; set; }
        public string ShippingCompanyId { get; set; }
        public string InfoPaymentsId { get; set; }
    }
}
