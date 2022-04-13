using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NTblPortalAssoc
    {
        public int? PortalUserId { get; set; }
        public string? AccountRef { get; set; }
        public int? LossAdjusterId { get; set; }
    }
}
