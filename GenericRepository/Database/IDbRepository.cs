using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public interface IDbRepository<T> where T : class
    {


        /// <summary>
        /// Insert Single 
        /// </summary>
        /// <param name="entity"></param>
        T Insert(T entity);
   
        /// <summary>
        /// Insert multiple 
        /// </summary>
        /// <param name="entity"></param>
        List<T> Insert(List<T> entity);
        /// <summary>
        /// Delete single
        /// </summary>
        /// <param name="entity"></param>
        T Delete(T entity);
        /// <summary>
        /// Delete multiple
        /// </summary>
        /// <param name="entity"></param>
        List<T> Delete(List<T> entity);
        /// <summary>
        /// Update 
        /// </summary>
        /// <param name="entity"></param>
        T Update(T entity);
        /// <summary>
        /// Update MultiPle
        /// </summary>
        /// <param name="entity"></param>
        List<T> Update(List<T> entity);
        /// <summary>
        /// Search Query
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IQueryable<T> Where(Expression<Func<T, bool>> predicate);
        /// <summary>
        /// Get List
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetAll();
        /// <summary>
        /// Get Single Object using int type id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(int id);
        /// <summary>
        /// Get Single Object using int type id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> GetByIdAsync(int id);
        /// <summary>
        /// Get Single Object using long type id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(long id);
        /// <summary>
        /// Get Single Object using string type id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(string id);
       


    }
}
