using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OutcomeCommodity
    {
        public int Id { get; set; }
        public int OutcomeId { get; set; }
        public int CommodityId { get; set; }
        public bool ShowOutcome { get; set; }

        public virtual Value1 Commodity { get; set; } = null!;
        public virtual ValidationOutcome Outcome { get; set; } = null!;
    }
}
