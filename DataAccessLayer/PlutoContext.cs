using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class PlutoContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        //public ApplicationContext(DbContextOptions<ApplicationContext> options)
        //    :base(options)
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            //Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = BVS; AttachDbFilename =| DataDirectory |\BVS_Db.mdf; Integrated Security = True; Connect Timeout = 30;
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog = BVS; Integrated Security=True;Connect Timeout=30");
        }
    }
}
