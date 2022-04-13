using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class FittingCost
    {
        public FittingCost()
        {
            FitterPricings = new HashSet<FitterPricing>();
        }

        public int FlFittingcostId { get; set; }
        public string Name { get; set; } = null!;
        public string Unit { get; set; } = null!;
        public decimal SbsCostPrice { get; set; }
        public decimal RrpIncVat { get; set; }
        public int? SpId { get; set; }
        public int? SupplierServiceId { get; set; }

        public virtual Product1? Sp { get; set; }
        public virtual Service? SupplierService { get; set; }
        public virtual ICollection<FitterPricing> FitterPricings { get; set; }
    }
}
