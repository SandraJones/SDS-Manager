using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDS_Manager.DAL
{
    public class Repository
    {
        readonly SDSDbContext _context;
        public Repository()
        {
            _context = new SDSDbContext();
        }
        public Repository(SDSDbContext context)
        {
            _context = context;
        }
        //this method is to get entire group 
        public IQueryable<TEntity> Query<TEntity>() where TEntity : class, IDbModel
        {
            return _context.GetCollection<TEntity>().AsQueryable();
        }
    }
}