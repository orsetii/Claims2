using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldTblCashSettlementReason
    {
        public int ReasonId { get; set; }
        public string ReasonText { get; set; } = null!;
    }
}
