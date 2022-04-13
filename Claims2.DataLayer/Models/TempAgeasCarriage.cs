using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class TempAgeasCarriage
    {
        public int? ClaimRef { get; set; }
        public string? Handler { get; set; }
        public string? DateClaimInvoiced { get; set; }
        public double? CarriageOvercharge { get; set; }
        public string? Notes { get; set; }
    }
}
