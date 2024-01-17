using AdaTech.AdaShop.Domain.Models;

namespace AdaTech.AdaShop.Domain.Infra.Data
{
    public interface ICustomerRepository
    {
        public void Insert(Customer obj);
        public void Update(Customer obj);
        List<Customer> GetAll();
        Customer GetById(string id);
    }
}
