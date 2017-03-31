using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using static System.Collections.Specialized.BitVector32;

namespace SDS_Manager.DAL
{
    public class SDSDbContext: DbContext
    {
        public virtual DbSet<Section>  Section { get; set; }
    }
    public DbSet<TEntity> GetCollection<TEntity>() where TEntity : class
    {
        return Set<TEntity>();
    }


}
