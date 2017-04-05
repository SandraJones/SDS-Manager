using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDS_Manager.Models
{
    public class PersonalGear
    {
        public int Eyewear { get; set; }//table includes # of protective glasses or side shields
        public int Gloves { get; set; }
        public int Labcoat { get; set; }
        public int OrganicsMask { get; set; }
    }
}