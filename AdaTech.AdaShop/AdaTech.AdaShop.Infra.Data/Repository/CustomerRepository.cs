using AdaTech.AdaShop.Domain.Infra.Data;
using AdaTech.AdaShop.Domain.Models;

namespace AdaTech.AdaShop.Infra.Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IRepositoryBase<Customer> _repository;
        public CustomerRepository(IRepositoryBase<Customer> repository)
        {
            _repository = repository;
        }

        public List<Customer> GetAll()
        {
            return _repository.GetAll();
        }

        public Customer GetById(string id)
        {
            return _repository.GetById(id);
        }

        public void Insert(Customer obj)
        {
            _repository.Insert(obj);
        }

        public void Update(Customer obj)
        {
            _repository.Update(obj);
        }
    }
}
