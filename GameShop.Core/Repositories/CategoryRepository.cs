using System;
using System.Collections.Generic;
using GameShop.Core.DataModels;
using GameShop.Core.Interfaces;

namespace GameShop.Core.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public void Insert(Category item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Category Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> Get(Func<Category, bool> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}