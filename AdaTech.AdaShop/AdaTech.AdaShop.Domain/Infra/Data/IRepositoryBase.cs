using AdaTech.AdaShop.Domain.Contracts;

namespace AdaTech.AdaShop.Domain.Infra.Data
{
    public interface IRepositoryBase<T> where T : IEntity
    {
        public void Insert(T obj);

        public void Update(T obj);
        IEnumerable<T> Get(Func<T, bool> func);
        List<T> GetAll();
        T GetById(string id);
        void Delete(string id);
    }
}
