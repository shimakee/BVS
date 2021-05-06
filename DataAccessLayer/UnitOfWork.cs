using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        ICustomerRepository Room { get; }
        Task<int> CompleteAsync();
        int Complete();
        void DetachAllEntries();
    }
}
