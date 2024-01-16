using MediatR;

namespace AdaTech.AdaShop.Application.Customer.Commands
{
    //Command => Classe que contém as informações externas para inserir os dados
    using Domain.Models;

    //Tudo o que um caso de uso vou herdar que IRequest
    public class AddCustomerCommand : IRequest<Customer>
    {
        public string Name { get; set; }
    }
}
