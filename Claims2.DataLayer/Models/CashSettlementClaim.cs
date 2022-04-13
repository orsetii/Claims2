using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CashSettlementClaim
    {
        public int CscId { get; set; }
        public int ClaimId { get; set; }
        public string Handler { get; set; } = null!;
        public DateTime TickedDate { get; set; }
    }
}
