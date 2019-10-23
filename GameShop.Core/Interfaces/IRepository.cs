using System;
using System.Collections.Generic;

namespace GameShop.Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Insert(T item);

        void Delete(Guid id);

        T Get(Guid id);

        void Update(T item);

        IEnumerable<T> Get(Func<T, bool> filter);

        IEnumerable<T> GetAll();
    }
}