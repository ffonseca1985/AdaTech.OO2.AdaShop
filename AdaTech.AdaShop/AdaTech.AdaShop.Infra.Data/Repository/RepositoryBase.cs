using AdaTech.AdaShop.Domain.Contracts;
using AdaTech.AdaShop.Domain.Infra.Data;

namespace AdaTech.AdaShop.Infra.Data.Repository
{
    //Camada de Infra é um servico que consulta servicos externos, por exemplo: Banco de dados, Uma api, Uma Dll, Um Fila etc
    public class RepositoryBase<T> : IRepositoryBase<T> where T : IEntity
    {
        //Customer
        //Este repositorio faz tudo, get, insert, update, delete

        //O chefe mudou a regra, agora customer não pode ser deletado
        private List<T> _itens;
        public RepositoryBase()
        {
            _itens = new List<T>();
        }

        public void Insert(T obj)
        {
            _itens.Add(obj);
        }

        public IEnumerable<T> Get(Func<T, bool> func)
        {
            return _itens.Where(func);
        }

        public List<T> GetAll()
        {
            return _itens;
        }

        public T GetById(string id)
        {

            var search = _itens.FirstOrDefault(x => x.ID == id);
            return search;
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
