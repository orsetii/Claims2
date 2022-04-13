using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class LatePo
    {
        public int LpId { get; set; }
        public int LpPodId { get; set; }
        public int LpClaimOrderId { get; set; }
        public int LpPomId { get; set; }
        public int LpClaimId { get; set; }
        public string? LpNotes { get; set; }
        public int LpStatus { get; set; }
        public int? LpUserId { get; set; }
    }
}
