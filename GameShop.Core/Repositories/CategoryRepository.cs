using System;
using System.Collections.Generic;
using GameShop.Core.DataModels;
using GameShop.Core.Interfaces;

namespace GameShop.Core.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public void Insert(ICategory item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public ICategory Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(ICategory item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ICategory> Get(Func<ICategory, bool> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ICategory> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}