using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class PerilAnalysis
    {
        public int ClaimId { get; set; }
        public string Guid { get; set; } = null!;
        public int ClaimPerilId { get; set; }
        public int ClaimPerilDetailId { get; set; }
        public string AvivaLossType { get; set; } = null!;
        public int? MatchedPerilDetailId { get; set; }
        public string? MatchedPerilDetailName { get; set; }
        public int? MatchedPerilId { get; set; }
        public string? Column9 { get; set; }
    }
}
