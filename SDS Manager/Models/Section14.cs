using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDS_Manager.Models
{
    public class Section14TransportInformation
    {
        public string DOTUNIDNo { get; set; }
        public string DOTProperShippingName { get; set; }
        public string DOTHazardClass { get; set; }
        public string DOTSpecialProvisions { get; set; }
        public string IMDGUNIDNo { get; set; }
        public string IMDGProperShippingName { get; set; }
        public string IMDGHazardClass { get; set; }
        public string IMDGAdditionalInformation { get; set; }
    }
}