using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDS_Manager.DAL
{
    public class IRepository
    {
        IQueryable<TEntity> Query<TEntity>() where TEntity : class, IDbModel;
        TEntity GetById<TEntity>(int id) where TEntity : class, IDbModel;
        void Insert<TEntity>(TEntity itemToInsert) where TEntity : class, IDbModel;
        void Delete<TEntity>(int id) where TEntity : class, IDbModel;
        void Upsert<TEntity>(TEntity objectToSave) where TEntity : class, IDbModel;
    }
}