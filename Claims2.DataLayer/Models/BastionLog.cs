using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BastionLog
    {
        public int LogId { get; set; }
        public int ClaimId { get; set; }
        public string Guid { get; set; } = null!;
        public string Question { get; set; } = null!;
        public string Answer { get; set; } = null!;
        public DateTime LogDate { get; set; }
        public int FraudScore { get; set; }
    }
}
