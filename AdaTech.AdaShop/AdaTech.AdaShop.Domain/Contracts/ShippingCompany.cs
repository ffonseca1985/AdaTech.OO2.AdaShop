using AdaTech.AdaShop.Domain.Models.Order;

namespace AdaTech.AdaShop.Domain.Contracts
{
    //Transportadora = Ideia, é abstração
    //O concreto da Transportadora, por exemplo é o correios 

    //caracteristicas de uma classe abstrata:
    // 1 => Não podemos dar new (não posso instanciar), porque é uma ideia (uma abstracao)
    public abstract class ShippingCompany : IEntity
    {
        public ShippingCompany(string id)
        {
            this.ID = id;
        }

        public string ID { get; private set; }

        //Calcula o Frete
        public abstract decimal CalculeShipping(OrderAggregate order);
    }
}