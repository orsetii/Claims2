using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ReportStat
    {
        public int Id { get; set; }
        public int ClaimId { get; set; }
        public int ReportId { get; set; }
        public int Time { get; set; }
        public DateTime ActionTime { get; set; }
    }
}
