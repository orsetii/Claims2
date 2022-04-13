using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CallReason
    {
        public CallReason()
        {
            CallProfiles = new HashSet<CallProfile>();
        }

        public int ReasonId { get; set; }
        public string? Reason { get; set; }

        public virtual ICollection<CallProfile> CallProfiles { get; set; }
    }
}
