using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class JewelleryBot
    {
        public int JewelleryBotId { get; set; }
        public int InsuranceClaimId { get; set; }
        public string Question { get; set; } = null!;
        public int QuestionId { get; set; }
        public string? Item1Name { get; set; }
        public string? Item2Name { get; set; }
        public int? TotalItemCount { get; set; }
        public int? PerilId { get; set; }
    }
}
