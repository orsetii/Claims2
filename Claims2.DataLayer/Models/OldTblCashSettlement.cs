using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldTblCashSettlement
    {
        public int CashSettlementId { get; set; }
        public int InsuranceClaimId { get; set; }
        public int ReasonId { get; set; }
        public string Comments { get; set; } = null!;
        public decimal LiabilitisedValue { get; set; }
    }
}
