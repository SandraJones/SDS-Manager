using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDS_Manager.Models
{
    public class Section2HazardsIdentification
    {
        public int ItemId { get; set; }
        public int CASnumber { get; set; }
        public string GHSClassification { get; set; }
        public string HazardStatement { get; set; } 
        public string Prevention { get; set; }
        public string Response { get; set; }
        public string Storage { get; set; }
         
    }
}