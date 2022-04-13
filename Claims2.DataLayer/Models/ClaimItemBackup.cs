using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ClaimItemBackup
    {
        public int ItemId { get; set; }
        public int ClaimId { get; set; }
        public int ProductId { get; set; }
        public int? ProductItemId { get; set; }
        public DateTime DateAdded { get; set; }
        public string? AlternateOutcome { get; set; }
        public string? AlternateOutcomeExplanation { get; set; }
        public int? DetailId { get; set; }
        public int? AgeofProduct { get; set; }
        public double? ValueofProduct { get; set; }
        public int? NumberofProducts { get; set; }
    }
}
