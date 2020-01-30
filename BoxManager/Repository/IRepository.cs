using System.Collections.Generic;

namespace BoxManager.Repository
{
    public interface IRepository<T, Id>
    {
        long Insert(T element);
        void Update(T element);
        void Delete(T element);
        void Delete(Id id);
        T GetById(Id id);
        IEnumerable<T> List();
    }
}
