using System.Collections.Generic;

namespace BoxManager.Controller
{
    public interface IController<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int Id);
        void Change(T entity);
        void Insert(T entity);
        void Delete(T entity);
        void Delete(int Id);
    }
}
