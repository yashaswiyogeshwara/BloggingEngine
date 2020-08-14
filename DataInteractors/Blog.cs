using System;
using System.Collections.Generic;

namespace DataInteractors
{
    public class Blog
    {
        
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Body { get; set; }
        public List<string> Hashtags { get; set; } 

    }
}
