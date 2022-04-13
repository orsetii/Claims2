using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Removetestcomment
    {
        public int ClaimCommentsHistoryId { get; set; }
        public int InsuranceClaimId { get; set; }
        public string Comments { get; set; } = null!;
        public string CreatedBy { get; set; } = null!;
    }
}
