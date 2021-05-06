using BusinessLayer;
using BusinessLayer.Repositories;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PlutoContext _context;
        public ICustomerRepository Customer { get; }
        public IVideoRepository Video { get; }
        public IVideoRentalRepository Rental { get; }

        public UnitOfWork(PlutoContext context)
        {
            _context = context;
            Customer = new CustomerRepository(context);
            Video = new VideoRepository(context);
            Rental = new VideoRentalRepository(context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void DetachAllEntries()
        {
            _context.ChangeTracker.Clear();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
