﻿using Ecommerce.Application.Repository;
using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.infrastructure.Services
{
    public class CategryRepository : ICategryRepositry
    {
        public Task<Catagory> CreateCategoryAsync(Catagory category)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Catagory>> GetAllCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Catagory> GetCategoryByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Catagory> UpdateCategoryAsync(Catagory category)
        {
            throw new NotImplementedException();
        }
    }
}
