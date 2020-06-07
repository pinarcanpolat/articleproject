using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Article.Repos.Contracts
{
    public interface IUnityOfWork : IDisposable
    {
        Task Commit();
    }
}
