using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SInspToReportTime
    {
        public int? SInspItem { get; set; }
        public int? Astat { get; set; }
        public string? Atstatd { get; set; }
        public int? Repstat { get; set; }
        public string? Repstatd { get; set; }
        public DateTime? Astaton { get; set; }
        public DateTime? Repstaton { get; set; }
    }
}
