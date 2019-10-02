using Microsoft.EntityFrameworkCore;
using Models.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database
{
    public class RepositoryDbContext:DbContext
    {
        public RepositoryDbContext(DbContextOptions<RepositoryDbContext> options):base(options)
        {

        }
       
        public new DbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Customer>();
         

        }
    }
}
