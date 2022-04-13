using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SLFaultType
    {
        public int SFaultTypeId { get; set; }
        public string? SFaultType { get; set; }
        public bool SFaultWarrantyFault { get; set; }
    }
}
