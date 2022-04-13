using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ClaimItem1
    {
        public ClaimItem1()
        {
            ItemFinances = new HashSet<ItemFinance>();
        }

        public int ItemId { get; set; }
        public int? ClaimClaimItemId { get; set; }
        public int? FnolitemId { get; set; }
        public int? InsuranceClaimId { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ItemPropertyIds { get; set; }
        public DateTime? DateConfirmed { get; set; }
        public bool Closed { get; set; }
        public DateTime? DateClosed { get; set; }
        public bool HadInspection { get; set; }
        public bool HadReplacement { get; set; }
        public bool HadRepair { get; set; }
        public int? OutcomeId { get; set; }
        public string Source { get; set; } = null!;

        public virtual InsuranceClaim? InsuranceClaim { get; set; }
        public virtual ICollection<ItemFinance> ItemFinances { get; set; }
    }
}
