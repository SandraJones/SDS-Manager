using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDS_Manager.Models
{
    public class SafetyEquipment
    {
        public int SafetyItemId { get; set; }
        public int Fixtures { get; set; } 
        public int DisposalContainers { get; set; }
    }
}