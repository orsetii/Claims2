using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Changesq
    {
        public int? ClaimId { get; set; }
        public string? Consignment { get; set; }
        public int? OldCat { get; set; }
        public int? NewCat { get; set; }
        public string? NewCattext { get; set; }
        public int? Ct { get; set; }
    }
}
