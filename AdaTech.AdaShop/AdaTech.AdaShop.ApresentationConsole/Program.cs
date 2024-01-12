namespace AdaTech.AdaShop.ApresentationConsole
{
    using AdaTech.AdaShop.Domain.Contracts;
    using AdaTech.AdaShop.Domain.Models.Order;
    using AdaTech.AdaShop.Domain.Models.ShippingCompany;
    using AdaTech.AdaShop.Domain.Models.Validators;

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

                TestCepFieldInAddress();
                TestNumberFieldInAddress();
                TestGenericValidator();


                Console.WriteLine("Deu tudo certo!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void TestCepFieldInAddress()
        {
            //Cep Validations 
            var address1 = new Address("Rua1", "2", "Casa", "Bairro1", "Cidade1", "Estado1", "40280000");
            //var address2 = new Address("Rua1", "2", "Casa", "Bairro1", "Cidade1", "Estado1", "4028000");
            //Output: O cep deve ter 8 caracteres.
            //var address3 = new Address("Rua1", "2", "Casa", "Bairro1", "Cidade1", "Estado1", "40-80000");
            //Output:O cep só pode ser composto por algarismos numéricos.
            //var address4 = new Address("Rua1", "2", "Casa", "Bairro1", "Cidade1", "Estado1", null);
            ////Output: Value cannot be null. (Parameter 'Cep')
            //var address5 = new Address("Rua1", "2", "Casa", "Bairro1", "Cidade1", "Estado1", "");
            ////Output: Value cannot be null. (Parameter 'Cep')
        }
        private static void TestNumberFieldInAddress()
        {
            //Number Validations
            var address6 = new Address("Rua1", "12", "Casa", "Bairro1", "Cidade1", "Estado1", "40280000");
            //var address7 = new Address("Rua1", "", "Casa", "Bairro1", "Cidade1", "Estado1", "40280000");
            //var address8 = new Address("Rua1", null, "Casa", "Bairro1", "Cidade1", "Estado1", "40280000");
            //var address9 = new Address("Rua1", "a", "Casa", "Bairro1", "Cidade1", "Estado1", "40280000");
        }
        private static void TestGenericValidator()
        {
            //Generic Validator Test

            NumberValidator<object?> numberValidator = new NumberValidator<object?>();

            //Char
            bool isCharValid = numberValidator.IsNumberValid('3', "testeChar");
            //bool isCharValid = numberValidatorChar.IsNumberValid('a', "testeChar");

            //String
            bool isStrValid = numberValidator.IsNumberValid("3", "testeString");
            //bool isStrValid = numberValidatorStr.IsNumberValid("a", "testeString");

            //Null
            //bool isNullValid = numberValidator.IsNumberValid(null, "testeNull");

            Console.WriteLine("Validação Char: " + isCharValid);
            Console.WriteLine("Validação String: " + isStrValid);
        }
    }
}
