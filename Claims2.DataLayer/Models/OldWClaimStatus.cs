using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldWClaimStatus
    {
        public int WClaimStatusId { get; set; }
        public string WClaimStatusDesc { get; set; } = null!;
        public bool WClaimStatusClose { get; set; }
    }
}
