using Blogger.Contracts;
using Data = DAL.Models;
using Blogger.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.Services
{
    public class CategoryService : ICategoryService
    {
        public async Task<bool> CheckIfCategoryExists(string name)
        {
            //fetch category by name
            return await Task<bool>.Run(() => true);
        }

        public Task<Data.Category> SaveCategory(Category category)
        {
            return null;
           // Save it later
        }
    }
}
