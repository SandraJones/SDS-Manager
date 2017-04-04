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
        //this method is to get one
        public TEntity GetById<TEntity>(int id) where TEntity : class, IDbModel
        {
            return _context.GetCollection<TEntity>().FirstOrDefault(XmlSiteMapProvider => XmlSiteMapProvider.Id == id);
        }
        //to add to the collection use Insert 
        public void Insert<TEntity>(TEntity itemToInsert)
        {
            _context.GetCollection<TEntity>().Add(itemToInsert);
        }
        public void Delete<TEntity>(int id) where TEntity : class IDbModel
        {
            _context.GetCollection<TEntity>().Remove(GetById<TEntity>(id));
        }
        //this method will update an existing item or insert a new item
        public void Upsert<TEntity>(TEntity objectToSave) where TEntity : class IDbModel
        {
            var exist = _context.GetCollection<TEntity>().Any(t => t.Id == objectToSave.Id);
            if (exist)
            {
                _context.GetCollection<TEntity>().Attach(objectToSave);
                _context.Entry(objectToSave).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                _context.GetCollection<TEntity>().Add(objectToSave);
            }
            _context.SaveChanges();
        }
        //method to invoke a  scraping action to collect info for each section/model using GrabzIt
        public void CollectSectionsText<TEntity>()
        {
            //code to prep for api call to msds resources 
        }
        public void SeparateIntoSections<TEntity>()
        {
            //code to take the collected sections text above, and separate into sections 
            //if Section matches Section 1 thru 16 with switch/case
        }
    }
}