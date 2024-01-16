using MediatR;

namespace AdaTech.AdaShop.Application.Customer.Commands
{
    //Edit é um caso de uso, logo herdo de IRequest
    public class EditCustomerCommand : IRequest<Unit>
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }
}
