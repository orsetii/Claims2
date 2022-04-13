using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class KeithCheckInvoice
    {
        public int LcshistoryId { get; set; }
        public int ClaimId { get; set; }
        public string ISSlTypeName { get; set; } = null!;
        public int ISSlTypeTl { get; set; }
        public int ISSlTypeTime { get; set; }
        public bool ISSlTypeCloses { get; set; }
        public bool ISSlMiClosed { get; set; }
    }
}
