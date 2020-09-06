using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class User
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModified { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
    }
}
