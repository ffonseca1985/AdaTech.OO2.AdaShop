using AdaTech.AdaShop.Application.Customer.Commands;
using AdaTech.AdaShop.Domain.Infra.Data;

namespace AdaTech.AdaShop.Application.Customer.Handler
{
    using Domain.Models;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    //Uma classe de Serviço que faz a integração com o domain e infra
    //Camada de Aplication:
    //1 - Controlador
    //2 - Orquestrador

    //Baseado no conceito de separacao de responsabilidade, criamos:
    //1 - camada de application
    //2 - separamos tudo em caso de uso
    //3 - e o caso de uso é executado por um handler

    //O que o pessoal do mercado usa para trabalhar com esta arquitetura de commandos?
    //Existe um biblioteca que padroniza este padrão que é o MediatR
    public class CustomerHandler : IRequestHandler<AddCustomerCommand, Customer>,
                                   IRequestHandler<EditCustomerCommand, Unit>
    {
        private readonly ICustomerRepository _repository;
        public CustomerHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public Task<Customer> Handle(AddCustomerCommand command, CancellationToken cancellationToken)
        {
            var customer = new Customer(command.Name);
            _repository.Insert(customer);

            return Task.FromResult(customer);
        }

        public Task<Unit> Handle(EditCustomerCommand command, CancellationToken cancellationToken)
        {
            Customer customer = _repository.GetById(command.ID);
            customer.Edit(command.Name);

            _repository.Update(customer);

            return Task.FromResult(Unit.Value);
        }


        //public void AddCustomer(AddCustomerCommand command)
        //{
        //    var customer = new Customer(command.Name);
        //    _repository.Insert(customer);
        //}

        //public void EditCustomer(EditCustomerCommand customerCommand)
        //{
        //    Customer customer = _repository.GetById(customerCommand.ID);
        //    customer.Edit(customerCommand.Name);

        //    _repository.Update(customer);
        //}
    }
}
