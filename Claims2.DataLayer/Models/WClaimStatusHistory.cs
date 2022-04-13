using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class WClaimStatusHistory
    {
        public int WClaimShId { get; set; }
        public int WClaimShClaimId { get; set; }
        public int WClaimShNewStatus { get; set; }
        public DateTime WClaimShDate { get; set; }
        public int WClaimShHandler { get; set; }
        public string? WClaimShComments { get; set; }
    }
}
