using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class AutoPriceChnote
    {
        public int ApchId { get; set; }
        public int ApchClaimId { get; set; }
        public int? ApchClaimOrderId { get; set; }
        public string? ApchNotes { get; set; }
    }
}
