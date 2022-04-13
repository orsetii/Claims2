using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CloseClaimLogTest
    {
        public int LogId { get; set; }
        public string LogSection { get; set; } = null!;
        public DateTime LogDate { get; set; }
    }
}
