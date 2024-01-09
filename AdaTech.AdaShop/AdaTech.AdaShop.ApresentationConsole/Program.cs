namespace AdaTech.AdaShop.ApresentationConsole
{
    using AdaTech.AdaShop.Domain.Contracts;
    using AdaTech.AdaShop.Domain.Models.Order;
    using AdaTech.AdaShop.Domain.Models.ShippingCompany;

    internal class Program
    {
        static void Main(string[] args)
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
