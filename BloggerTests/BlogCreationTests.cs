using System;
using Xunit;
using Blogger;
using DataInteractors;
using Blogger.Contracts;
using Blogger.Services;
using System.Collections.Generic;

namespace BloggerTests
{
    public class BlogCreationTests
    {
        [Fact]
        public async void CreateADraftWithOnlyTitle()
        {
            Blog simpleBlog = new Blog();
            simpleBlog.Title = "My First Blog";
            ICategoryService categoryService = new CategoryService();
            IBlogCreator blogCreater = new BlogCreator(categoryService);
            var exception = await  Record.ExceptionAsync(() => blogCreater.CreateDraft(simpleBlog));
            Assert.Null(exception);
        }

        [Fact]
        public async void CreateADraftWithContent() {
            Blog contentBlog = new Blog();
            contentBlog.Title = "Content Blog";
            contentBlog.Body = "<a>This is my blog<a>";
            contentBlog.SubTitle = "This is a subtitle";
            ICategoryService categoryService = new CategoryService();
            IBlogCreator blogCreater = new BlogCreator(categoryService);
            var exception = await Record.ExceptionAsync(() => blogCreater.CreateDraft(contentBlog));
            Assert.Null(exception);
        }

        [Fact]
        public async void AddCategoriesToADraft() {
            Blog foodBlog = new Blog();
            foodBlog.Hashtags = new List<string>() { "food", "italian", "lasanga" };
            foodBlog.Title = "An Italian Food Blog";
            ICategoryService categoryService = new CategoryService();
            IBlogCreator blogCreater = new BlogCreator(categoryService);
            var exception = await Record.ExceptionAsync(() => blogCreater.CreateDraft(foodBlog));
            Assert.Null(exception);
        }
        [Fact]
        public async void AddBlogWithCategories()
        {
            Blog foodBlog = new Blog();
            foodBlog.Hashtags = new List<string>() { "food", "italian", "lasanga" };
            foodBlog.Title = "An Italian Food Blog";
            ICategoryService categoryService = new CategoryService();
            IBlogCreator blogCreater = new BlogCreator(categoryService);
            var exception = await Record.ExceptionAsync(() => blogCreater.CreateBlog(foodBlog));
            Assert.Null(exception);
        }


    }
}
