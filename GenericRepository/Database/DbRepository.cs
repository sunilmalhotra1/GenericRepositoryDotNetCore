using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class DbRepository<T> : IDbRepository<T> where T : class
    {
        private DbSet<T> DbSet;
        private RepositoryDbContext DbContext;
       
        public DbRepository(RepositoryDbContext iDbContext)
        {

            this.DbContext = iDbContext;
            this.DbSet = this.DbContext.Set<T>();
        }

        #region IRepository<T> Members


     

        /// <summary>
        /// Insert Single  
        /// </summary>
        /// <param name="entity"></param>
        public T Insert(T entity)
        {
             this.DbSet.Add(entity);
            return entity;

        }
        /// <summary>
        /// Insert Multiple
        /// </summary>
        /// <param name="entities"></param>
        public List<T> Insert(List<T> entities)
        {
            List<T> list = new List<T>();
            foreach (var entity in entities)
            {
                this.DbSet.Add(entity);
                list.Add(entity);

            }
            return list;

        }

        /// <summary>
        /// Delete Single
        /// </summary>
        /// <param name="entity"></param>
        public T Delete(T entity)
        {
             this.DbSet.Remove(entity);
            return entity;

        }

        /// <summary>
        /// Delete multiple
        /// </summary>
        /// <param name="entities"></param>
        public List<T> Delete(List<T> entities)
        {
            List<T> list = new List<T>();
            foreach (var entity in entities)
            {
                this.DbSet.Remove(entity);
                list.Add(entity);


            }
            return list;

        }
        /// <summary>
        /// Update 
        /// </summary>
        /// <param name="entity"></param>
        public T Update(T entity)
        {
            var obj = this.DbSet.Attach(entity);
            this.DbContext.Entry(entity).State = EntityState.Modified;
            return entity;

        }

        /// <summary>
        /// Delete multiple
        /// </summary>
        /// <param name="entities"></param>
        public List<T> Update(List<T> entities)
        {
            List<T> list = new List<T>();
            foreach (var entity in entities)
            {
                this.DbSet.Attach(entity);
                list.Add(entity);
                this.DbContext.Entry(entity).State = EntityState.Modified;

            }
            return list;

        }
        /// <summary>
        /// Search Query
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        {
            return this.DbSet.Where(predicate).AsQueryable<T>();
        }
        /// <summary>
        /// Get List
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetAll()
        {
            return this.DbSet;
        }
        /// <summary>
        /// Get Single Object using int type id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(int id)
        {
            return this.DbSet.Find(id);
        }
        /// <summary>
        /// Get Single Object using int type id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<T> GetByIdAsync(int id)
        {
            return await Task.FromResult(this.DbSet.Find(id));
        }
        /// <summary>
        /// Get Single Object using long type id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(long id)
        {
            return this.DbSet.Find(id);
        }
        /// <summary>
        /// Get Single Object using string type id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(string id)
        {
            return this.DbSet.Find(id);
        }

      
        /// <summary>
        /// Save Change the entity
        /// </summary>
        /// <returns></returns>
        public int SaveChanges()
        {
            return this.DbContext.SaveChanges();
        }

        #endregion
    }
}
