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

            try
            {
                ShippingCompany correiosShippingCompany = new CorreiosShippingCompany();
                ShippingCompany uberShippingCompany = new UberShippingCompany();

                var order1 = new OrderAggregate(customer: null, shippingCompany: correiosShippingCompany);
                var order2 = new OrderAggregate(customer: null, shippingCompany: uberShippingCompany);

                var address1 = new Address("Rua1", "2", "Casa", "Bairro1", "Cidade1", "Estado1", "40280000");

                //Cep Validations

                //var address2 = new Address("Rua1", "2", "Casa", "Bairro1", "Cidade1", "Estado1", "4028000");
                //Output: O cep deve ter 8 caracteres.
                //var address3 = new Address("Rua1", "2", "Casa", "Bairro1", "Cidade1", "Estado1", "40-80000");
                //Output:O cep só pode ser composto por algarismos numéricos.
                //var address4 = new Address("Rua1", "2", "Casa", "Bairro1", "Cidade1", "Estado1", null);
                ////Output: Value cannot be null. (Parameter 'Cep')
                //var address5 = new Address("Rua1", "2", "Casa", "Bairro1", "Cidade1", "Estado1", "");
                ////Output: Value cannot be null. (Parameter 'Cep')

                Console.WriteLine("Deu tudo certo!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
