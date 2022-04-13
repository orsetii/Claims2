using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class AlternativeOutcome
    {
        public AlternativeOutcome()
        {
            ClaimItem2s = new HashSet<ClaimItem2>();
        }

        public int OutcomeId { get; set; }
        public string OutcomeText { get; set; } = null!;
        public bool? Show { get; set; }

        public virtual ICollection<ClaimItem2> ClaimItem2s { get; set; }
    }
}
