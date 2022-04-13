using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ReportLog
    {
        public int LogId { get; set; }
        public string LogReport { get; set; } = null!;
        public DateTime LogDate { get; set; }
    }
}
