using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SStatusT
    {
        public int STrackerId { get; set; }
        public int? SInspItem { get; set; }
        public int? SInsuranceClaim { get; set; }
        public string? SStatusDesc { get; set; }
        public int? SStatusTo { get; set; }
        public DateTime? SStatusOn { get; set; }
        public int? SInspCompany { get; set; }
        public string? SInspCoDesc { get; set; }
        public int? SInspType { get; set; }
        public string ProductCode { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
