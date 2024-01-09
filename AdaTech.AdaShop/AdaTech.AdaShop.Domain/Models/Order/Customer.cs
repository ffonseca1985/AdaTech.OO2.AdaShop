using AdaTech.AdaShop.Domain.Contracts;

namespace AdaTech.AdaShop.Domain.Models.Order
{
    public class Customer : IEntity
    {
        public string ID { get; private set; }
    }
}