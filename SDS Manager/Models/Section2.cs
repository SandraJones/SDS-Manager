using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDS_Manager.Models
{
    public class Section2
    {
        public string GHSClassification { get; set; }
        public string HazardStatement { get; set; }
        public class PrecautionaryStatements()
        {
            public string Prevention { get; set; }
            public string Response { get; set; }
            public string Storage { get; set; }
         }

    }
}