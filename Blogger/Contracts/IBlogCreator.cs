using DataInteractors;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.Contracts
{
    public interface IBlogCreator
    {
        public Task CreateDraft(Blog blog);

    }
}
