using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class STimeToReportByInsp
    {
        public int? SInspItem { get; set; }
        public DateTime? Astaton { get; set; }
        public DateTime? Repstaton { get; set; }
        public int? Timetoreport { get; set; }
        public string? SInspCoDesc { get; set; }
        public int SInspCo { get; set; }
    }
}
