using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Closed
    {
        public int? ClaimId { get; set; }
        public string? Consignment { get; set; }
        public DateTime? OpenDate { get; set; }
        public int? OpenMonth { get; set; }
        public int? OpenYear { get; set; }
        public string? Openx { get; set; }
    }
}
