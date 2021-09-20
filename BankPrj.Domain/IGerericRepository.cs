using System.Collections.Generic;

namespace BankPrj.Domain
{
    public interface IGerericRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        int Add(T entity);
        int Update(T entity);
        void Delete(int id);
    }
}
