using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ItemOutcome
    {
        public int OutcomeId { get; set; }
        public string? OutcomeName { get; set; }
        public int? OldMioutcome { get; set; }
    }
}
