using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database
{
    public interface IDbService
    {
        /// <summary>
        /// Begin Transaction
        /// </summary>
        /// <returns></returns>
        IDbContextTransaction BeginTransaction();
        /// <summary>
        /// Begin Transaction
        /// </summary>
        /// <param name="isolationLevel"></param>
        /// <returns></returns>
       // IDbContextTransaction BeginTransaction(IsolationLevel isolationLevel);
        /// <summary>
        /// Execute Sql
        /// </summary>
        /// <param name="elementType"></param>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        //DbRawQuery SqlQuery(Type elementType, string sql, params object[] parameters);


        /// <summary>
        /// Generic Entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        DbSet<T> SetEntity<T>() where T : class;
        /// <summary>
        /// Save change the context
        /// </summary>
        void SaveChanges();

        /// <summary>
        /// 
        /// </summary>
        void Dispose();
        /// <summary>
        /// 
        /// </summary>
        Task<bool> DisposeAsync();
    }
}
