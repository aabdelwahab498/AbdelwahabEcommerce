using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Repository
{
    public interface ICategryRepositry 
    {
        Task<IEnumerable<Catagory>> GetAllCategoriesAsync();
        Task<Catagory> GetCategoryByIdAsync(int id);
        Task<Catagory> CreateCategoryAsync(Catagory category);
        Task<Catagory> UpdateCategoryAsync(Catagory category);
        Task DeleteCategoryAsync(int id);
    }
}
