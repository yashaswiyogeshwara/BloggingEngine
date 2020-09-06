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

         async Task<bool> ICategoryService.CheckIfCategoryExists(string name)
        {
            return await Task<bool>.Run(() => true);
        }

         async Task<Data.Category> ICategoryService.SaveCategory(Entities.Category category)
        {
            return null;
        }
    }
}
