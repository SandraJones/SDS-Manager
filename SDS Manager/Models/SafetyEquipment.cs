using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDS_Manager.Models
{
    public class SafetyEquipment
    {
        public int Eyewear { get; set; }//table includes # of protective glasses or side shields
        public int VentHoods { get; set; } 
        public int LabCoats { get; set; }
        public int SafetyShowers { get; set; }
        public int Gloves { get; set; }
        public int Facemask { get; set; }
        public int FireBlanket { get; set; }
        public int EyewashStations { get; set; }
        public int FlammableStorageCabinets { get; set; }
        public int FireExtinguishers { get; set; }
        public int OrganicWasteDisposalContainers { get; set; }
    }
}