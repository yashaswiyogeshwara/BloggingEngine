using Data = DAL.Models;
using Blogger.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.Contracts
{
    //Use of Internal Interface and therfore explicit creation of the class.
    //https://alexfranchuk.com/blog/internal-interface-classes-in-csharp/#:~:text=In%20C%23%2C%20interfaces%20can%20only,internal%2C%20rather%20than%20public).
    public interface ICategoryService
    {
        public Task<Data.Category> SaveCategory(Category category);
        public Task<bool> CheckIfCategoryExists(string name);
    }
}
