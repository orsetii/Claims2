using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldSStatTran
    {
        public int STrackerId { get; set; }
        public int? SInsuranceClaim { get; set; }
        public int? SInspItem { get; set; }
        public int? SStatusFrom { get; set; }
        public int? SStatusTo { get; set; }
        public string? SStatusBy { get; set; }
        public DateTime? SStatusOn { get; set; }
    }
}
