using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ActionHistory
    {
        public int Id { get; set; }
        public int InsuranceClaimId { get; set; }
        public DateTime Date { get; set; }
        public int ActionId { get; set; }
        public string User { get; set; } = null!;
        public int? UserControlContextId { get; set; }
        public int? OutcomeOptionsId { get; set; }

        public virtual Action Action { get; set; } = null!;
        public virtual InsuranceClaim1 InsuranceClaim { get; set; } = null!;
        public virtual ClaimActionOutcome? OutcomeOptions { get; set; }
    }
}
