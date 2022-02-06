using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Base;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T FindById(long id);
        List<T> FindAll();
        void Delete(long id);
        T Update(T item);

        bool Exists(long Id);
    }
}
