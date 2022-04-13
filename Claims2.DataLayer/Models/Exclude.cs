using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Exclude
    {
        public int MieId { get; set; }
        public int MieClaimId { get; set; }
        public string? MieReason { get; set; }
    }
}
