using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BastionProgress
    {
        public int ProgressId { get; set; }
        public int ClaimId { get; set; }
        public int Stage { get; set; }
        public DateTime LogDate { get; set; }
    }
}
