using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database
{
    public class DbService : IDbService
    {
        private RepositoryDbContext _Context;
        public DbService(RepositoryDbContext _iContext)
        {
            this._Context = _iContext;
        }
        public IDbContextTransaction BeginTransaction()
        {
            return this._Context.Database.BeginTransaction();
        }


        public void Dispose()
        {
            this._Context.Dispose();
        }

        public async Task<bool> DisposeAsync()
        {
            this._Context.Dispose();
            return await Task.FromResult(true);
        }

        public DbSet<T> SetEntity<T>() where T : class
        {
            return this._Context.Set<T>();
        }

        public void SaveChanges()
        {
            this._Context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await this._Context.SaveChangesAsync();
        }



    }
}
