using Blogger.Contracts;
using Blogger.Entities;
using Interactors = DataInteractors;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Entities = Blogger.Entities;

namespace Blogger.Services
{
    public class BlogCreator : IBlogCreator
    {
        private ICategoryService categoryService { get; set; }
        public BlogCreator(ICategoryService categoryService) {
            this.categoryService = categoryService;
        }
        public async Task CreateDraft(Interactors.Blog blog)
        {
            try
            {   
                Entities.Blog draft = new Entities.Blog();
                draft.Title = blog.Title;
                draft.Body = blog.Body;
                draft.IsPublished = false;
                if (blog.Hashtags !=null && blog.Hashtags.Count > 0) {
                    blog.Hashtags.ForEach(async (name) =>
                    {
                        Hashtag hashtag = await Hashtag.Create(name,categoryService).ConfigureAwait(false);
                    });
                }
                await SaveBlog(draft).ConfigureAwait(false);
            }
            catch (Exception ex) {
                throw new Exception("Error while Creating Blog", ex.InnerException);
            }
        }
        public async Task CreateBlog(Interactors.Blog blog)
        {
            try
            {
                Entities.Blog draft = new Entities.Blog();
                draft.Title = blog.Title;
                draft.Body = blog.Body;
                draft.IsPublished = true;
                await draft.AddHashtags(blog.Hashtags,categoryService).ConfigureAwait(false);
                await SaveBlog(draft).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }


        private async Task SaveBlog(Blog draft) {
            await Task.Run(() => { }); // Task.Run() not to be used in I/O bound tasks and should only be used for CPU bound tasks.
        } 

    }
}
