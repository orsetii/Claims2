using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CloseRemainingClaim
    {
        public bool Closed { get; set; }
        public int ClaimCloseDays { get; set; }
        public DateTime? OpenDate { get; set; }
        public int? DaysOpen { get; set; }
    }
}
