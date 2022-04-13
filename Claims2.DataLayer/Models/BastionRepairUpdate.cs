using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BastionRepairUpdate
    {
        public int RepairId { get; set; }
        public int ClaimId { get; set; }
        public string? RepairStatus { get; set; }
        public string RepairSupplier { get; set; } = null!;
        public DateTime UpdateDate { get; set; }
        public string? ReceivedDate { get; set; }
    }
}
