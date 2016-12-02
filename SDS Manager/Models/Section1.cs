using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SDS_Manager.Models
{
    public class Section1
    {
        public int CASnumber { get; set;}
        public string ProductName { get; set; }
        public string ExtinguishingMedia {get; set;}
        public string SpecialHazards { get; set; }
        public string ManufacturerName { get; set;}

    }
}