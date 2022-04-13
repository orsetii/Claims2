using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class WClaimStatus
    {
        public int WClaimStatusId { get; set; }
        public string WClaimStatusDesc { get; set; } = null!;
        public bool WClaimStatusClose { get; set; }
    }
}
