using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDS_Manager.Models
{
    public class Section9PhysicalChemicalProperties
    {
        public string Appearance { get; set; }
        public string Odour { get; set; }
        public string OdourThreshold { get; set; }
        public string pH { get; set; }
        public string MeltingPointFreezingPoint { get; set; }
        public string InitialBoilingPointAndBoilingRange { get; set; }
        public string FlashPoint { get; set; }
        public string EvaporationRate { get; set; }
        public string FlammabilitySolidGas { get; set; }
        public string UpperLowerFlammabilityExplosiveLimits { get; set; }
        public string VapourPressure { get; set; }
        public string VapourDensity { get; set; }
        public string RelativeDensity { get; set; }
        public string WaterSolubility { get; set; }
        public string PartitionCoefficient { get; set; }
        public string AutoIgnition { get; set; }
        public string DecompositionTemperature { get; set; }
        public string Viscosity { get; set; }
        public string ExplosiveProperties { get; set; }
        public string OxidizingProperties { get; set; }
        public string OtherSafetyInformation { get; set; }

    }
}