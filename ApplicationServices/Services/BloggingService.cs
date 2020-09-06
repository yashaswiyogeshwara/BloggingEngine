using ApplicationServices.Contracts;
using Blogger.Contracts;
using Blogger.Services;
using DataInteractors;
using System;
using System.Threading.Tasks;

namespace ApplicationServices
{
    public class BloggingService : IBloggingService
    {
        private IBlogCreator blogCreator;
        public BloggingService(IBlogCreator blogCreator) {
            this.blogCreator = blogCreator;
        }
        public async Task CreateBlog(Blog blog)
        { 
            await blogCreator.CreateBlog(blog);
        }

        public async Task CreateDraft(Blog blog)
        {
            await blogCreator.CreateDraft(blog);
        }
    }
}
