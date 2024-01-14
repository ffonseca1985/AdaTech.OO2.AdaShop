using AdaTech.AdaShop.Domain.Contracts;

namespace AdaTech.AdaShop.Domain.Infra
{
    public interface IRepositoryBase<T> where T : IEntity
    {
        void Insert(T obj);
        IEnumerable<T> Get(Func<T, bool> func);
        List<T> GetAll();
        T GetById(string id);
    }
}
