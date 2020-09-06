using Blogger.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.Entities
{
    public class Blog
    {   
        public string Title { get; set; }
        public bool IsPublished { get; set; }
        public string Body { get; set; }
        public List<Hashtag> Hashtags { get; set; }
        internal async Task AddHashtags(List<string> hashtagNames, ICategoryService categoryService) {
            Hashtags = new List<Hashtag>();
            
            if (hashtagNames != null && hashtagNames.Count > 0)
            {
                hashtagNames.ForEach(async (name) =>
                {
                    
                    Hashtag hashtag = await Hashtag.Create(name, categoryService).ConfigureAwait(false);
                    Hashtags.Add(hashtag);
                });
            }
        }
    }
}
