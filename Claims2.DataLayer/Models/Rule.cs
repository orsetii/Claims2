using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Rule
    {
        public int RuleId { get; set; }
        public string ItemPropertyIds { get; set; } = null!;
        public int OutcomeId { get; set; }
        public DateTime DateAdded { get; set; }
        public bool Important { get; set; }
    }
}
