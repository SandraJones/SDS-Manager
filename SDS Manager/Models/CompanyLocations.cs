using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDS_Manager.Models
{
    public class CompanyLocations
    {
        public int LocationId { get; set; }
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string StateOrProvince { get; set; }
        public string Country { get; set; }
        public int CompanyLocationID { get; set; }
        public string onSiteSafetyManager { get; set; }
    }
}