using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldMiChange
    {
        public int? ClaimId { get; set; }
        public string? Consignment { get; set; }
        public int? OldCat { get; set; }
        public string? OldCattext { get; set; }
        public int? NewCat { get; set; }
        public string? NewCattext { get; set; }
    }
}
