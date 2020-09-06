using Blogger.Contracts;
using Blogger.Entities;
using Blogger.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BloggerTests
{
    public class CategoryCreationTests
    {
        private ICategoryService categoryService;
        public CategoryCreationTests()
        {
            this.categoryService = new CategoryService();

        }
        [Fact]
        public async void CreateCategoryWithDesciption()
        {   
            //var category = await Category.Create("Programming", "Subscribe to this category if you are interested in Programming", categoryService);
            //Assert.Equal("Subscribe to this category if you are interested in Programming", category.Description);
            //Assert.Equal("Programming", category.Name);

        }
    }
}
