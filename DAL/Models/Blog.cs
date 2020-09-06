using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Blog
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public bool IsPublished { get; set; }
        public List<Category> Hashtags { get; set; }
        public Guid PublicId { get; set; }
        public User Author { get; set; }
    }
}
