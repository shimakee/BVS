using BusinessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IUnitOfWork : IDisposable
    {
        IVideoRepository Video { get; }
        ICustomerRepository Customer { get; }
        Task<int> CompleteAsync();
        int Complete();
        void DetachAllEntries();
    }
}
