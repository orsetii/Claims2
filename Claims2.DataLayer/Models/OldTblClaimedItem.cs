using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldTblClaimedItem
    {
        public int ClaimItemId { get; set; }
        public int ClaimId { get; set; }
        public int? ProductTypeId { get; set; }
        public double? ClaimedValue { get; set; }
        public string? Description { get; set; }
        public string? ProductParticulars { get; set; }
        public int? ProductId { get; set; }
        public int? ProductItemId { get; set; }
        public int? OutcomeId { get; set; }
    }
}
