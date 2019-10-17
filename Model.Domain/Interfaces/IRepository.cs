using Model.Domain.Entities;
using System.Collections.Generic;

namespace Model.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Insert(T obj);

        void Update(T obj);

        void Remove(int id);

        T SelectById(int id);

        IList<T> SelectAll();
    }
}
