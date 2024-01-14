using AdaTech.AdaShop.Application.Customer.Commands;
using MediatR;
using System;

namespace AdaTech.AdaShop.Application.Customer.Handlers
{
    using AdaTech.AdaShop.Domain.Infra;
    using Domain.Models;
    using System.Threading;

    public class CustomerHandler : IRequestHandler<AddCustomerCommand, Customer>,
                                   IRequestHandler<DeleteCustomerCommand, bool> 
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

        public Task<bool> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            var result = _repository.Delete(request.ID);
            return Task.FromResult(result); 
        }
    }
}
