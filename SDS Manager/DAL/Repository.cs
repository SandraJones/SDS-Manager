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

    }
}