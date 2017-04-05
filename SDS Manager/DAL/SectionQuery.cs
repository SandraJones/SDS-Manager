using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDS_Manager.DAL
{
    public class SectionQuery
    {
        readonly IRepository _repository;
        public class SectionQuery()
        {
            _repository = new Repository();
        }
    }
    public TaskQuery(IRepository repository)
    {
        _repository = repository;
    }
}
