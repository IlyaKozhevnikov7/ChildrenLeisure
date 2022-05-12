using System;
using System.Collections.Generic;

namespace DAL
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetById(int id);

        void Add(T entity);

        void Update(T entity);
    }
}
