using System;
using System.Collections.Generic;
using System.Text;

namespace Blogger.Entities
{
    public class Blog
    {   
        public string Title { get; set; }
        public bool IsPublished { get; set; }
        public string Body { get; set; }
        public List<Hashtag> Hashtags { get; set; }
    }
}
