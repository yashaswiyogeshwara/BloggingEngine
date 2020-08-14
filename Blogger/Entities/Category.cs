using Blogger.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.Entities
{
    public class Category
    {   
        protected Category(string name, string description) {
            this.Name = name;
            this.Description = description;
        }

        public int Id { get; }
        public string Name { get;}
        public string Description { get; }

        public static async Task<Category> Create(string name, string Description, ICategoryService categoryService) {
            var newCategory = new Category(name, Description);
            if (await categoryService.CheckIfCategoryExists(name) == false)
            {
                await categoryService.SaveCategory(newCategory);
            }
            return newCategory;
        }

    }
}
