using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDS_Manager.Models
{
    public class Section11ToxicologicalInformation
    {
        public string AcuteToxicity { get; set; }
        public string SkinCorrosionIrritation { get; set; }
        public string SeriousEyeDamageEyeIrritation { get; set; }
        public string RespiratorySkinSensitisation { get; set; }
        public string GermCellMutagenicity { get; set; }
        public string Carcinogenicity { get; set; }
        public string ReproductiveToxicity { get; set; }
        public string SpecificTargetOrganToxicitySingleExposure { get; set; }
        public string SpecificTargetOrganToxicityRepeatedExposure { get; set; }
        public string AspirationHazard { get; set; }
        public string AdditionalInformation { get; set; }
    }
}