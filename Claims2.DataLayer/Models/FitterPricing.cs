using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class FitterPricing
    {
        public int FlFitterpricing { get; set; }
        public int FittingcostId { get; set; }
        public int FitterId { get; set; }
        public decimal Buyrate { get; set; }
        public decimal Sellrate { get; set; }

        public virtual Fitter Fitter { get; set; } = null!;
        public virtual FittingCost Fittingcost { get; set; } = null!;
    }
}
