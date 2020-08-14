using Data = DAL.Models;
using Blogger.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.Contracts
{
    public interface ICategoryService
    {
        public  Task<Data.Category> SaveCategory(Category category);
        public  Task<bool> CheckIfCategoryExists(string name);
    }
}
