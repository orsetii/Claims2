using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class QSla72
    {
        public int InsuranceClaimId { get; set; }
        public string? AccountRef { get; set; }
        public int? SStatusFrom { get; set; }
        public int? SStatusTo { get; set; }
        public DateTime? SStatusOn { get; set; }
        public DateTime DateInstructed { get; set; }
    }
}
