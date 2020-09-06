using Blogger.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.Entities
{
    public class Hashtag : Category
    {   
        private Hashtag(string name) : base(name, null){
            
        }
        internal async static Task<Hashtag> Create(string name, ICategoryService categoryService) {
            
            await Create(name, null, categoryService);
            return new Hashtag(name);
        }
    }
}
