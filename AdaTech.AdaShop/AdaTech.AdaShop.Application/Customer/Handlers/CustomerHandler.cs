using AdaTech.AdaShop.Application.Customer.Commands;
using MediatR;
using System;

namespace AdaTech.AdaShop.Application.Customer.Handlers
{
    using AdaTech.AdaShop.Domain.Infra;
    using Domain.Models;
    using System.Threading;

    public class CustomerHandler : IRequestHandler<AddCustomerCommand, Customer>
    {
        readonly IRepositoryBase<Customer> _repository;
        public CustomerHandler(IRepositoryBase<Customer> repository)
        {
            _repository = repository;
        }

        public Task<Customer> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = new Customer(request.Name);
            _repository.Insert(customer);

            return Task.FromResult(customer);
        }
    }
}
