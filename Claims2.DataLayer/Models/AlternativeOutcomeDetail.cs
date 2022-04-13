using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class AlternativeOutcomeDetail
    {
        public int DetailId { get; set; }
        public int OutcomeId { get; set; }
        public string DetailText { get; set; } = null!;
    }
}
