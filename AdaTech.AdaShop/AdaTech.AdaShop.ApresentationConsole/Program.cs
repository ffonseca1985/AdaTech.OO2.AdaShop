namespace AdaTech.AdaShop.ApresentationConsole
{
    using AdaTech.AdaShop.Domain.Contracts;
    using AdaTech.AdaShop.Domain.Models;
    using AdaTech.AdaShop.Domain.Models.Order;
    using AdaTech.AdaShop.Domain.Models.ShippingCompany;
    using AdaTech.AdaShop.Infra.Data.Repository;

    internal class Program
    {
        static void Main(string[] args)
        {
            //DDD
            //separation of Concern

            var customer = new Customer("Fábio");
            var repository = new RepositoryBase<Customer>();

            repository.Insert(customer);
        }

        void Aula2()
        {
            //Polimorfismo
            ShippingCompany correiosShippingCompany = new CorreiosShippingCompany();
            ShippingCompany uberShippingCompany = new UberShippingCompany();

            var order1 = new OrderAggregate(customer: null, shippingCompany: correiosShippingCompany);
            var order2 = new OrderAggregate(customer: null, shippingCompany: uberShippingCompany);

            Console.WriteLine("Hello, World!");
        }
    }
}
