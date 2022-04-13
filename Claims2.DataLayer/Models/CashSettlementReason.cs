using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CashSettlementReason
    {
        public int ReasonId { get; set; }
        public string ReasonText { get; set; } = null!;
    }
}
