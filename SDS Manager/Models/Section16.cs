using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDS_Manager.Models
{
    public class Section16OtherInformation
    {
        public class NFPA
        {
            public string HealthHazards { get; set; }
            public string Flammability { get; set; }
            public string Instability { get; set; }
            public string Special { get; set; }
        }
        public class HMIS
        {
            public string HealthHazards { get; set; }
            public string Flammability { get; set; }
            public string PhysicalHazards { get; set; }
        }
        public string RevisionDate { get; set; }
        public string ReasonsForRevision { get; set; }
        public string Disclaimer { get; set; }

    }
}
