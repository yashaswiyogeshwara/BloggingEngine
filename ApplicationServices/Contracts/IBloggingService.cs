using DataInteractors;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Contracts
{
    public interface IBloggingService
    {
        public Task CreateDraft(Blog blog);
        public Task CreateBlog(Blog blog);
    }
}
