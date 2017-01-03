using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDS_Manager.Models
{
    public class Section15RegulatoryInformation
    {
        public string TSCAStatus { get; set; }
        public string SARA313ListedSubstances { get; set; }
        public class  SARAHazardCategories
        {
            public string AcuteHealthHazard { get; set; }
            public string ChronicHealthHazard { get; set; }
            public string FireHazard { get; set; }
            public string SuddenReleaseOfPressureHazard { get; set; }
            public string ReactiveHazard { get; set; }
            public string CaliforniaProposition65 { get; set; }
            public string EPAPesticideRegistrationNumber { get; set; }
            public string EPAStatement { get; set; }
            public string EPAPesticideLabel { get; set; }
        }
            
    }
}