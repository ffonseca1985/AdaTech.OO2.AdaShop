using MediatR;

namespace AdaTech.AdaShop.Application.Customer.Commands
{
    using Domain.Models;
    using System.ComponentModel.DataAnnotations;

    public class AddCustomerCommand : IRequest<Customer>
    {
        [Required]
        public string Name { get; set; }
    }
}
