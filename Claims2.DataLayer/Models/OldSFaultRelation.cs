using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldSFaultRelation
    {
        public int FaultTypeId { get; set; }
        public int? SFaultTypeId { get; set; }
        public int? ItemTypeId { get; set; }
        public int? FixRateIndex { get; set; }
    }
}
