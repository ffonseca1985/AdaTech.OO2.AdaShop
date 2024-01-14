using MediatR;

namespace AdaTech.AdaShop.Application.Customer.Commands
{
    public class DeleteCustomerCommand : IRequest<bool>
    {
        public DeleteCustomerCommand(string iD)
        {
            ID = iD;
        }

        public string ID { get; set; }
    }
}
