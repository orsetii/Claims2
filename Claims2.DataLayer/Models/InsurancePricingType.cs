using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class InsurancePricingType
    {
        public InsurancePricingType()
        {
            InsurancePricings = new HashSet<InsurancePricing>();
        }

        public int FlInsurancePricingTypeId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Adjustment { get; set; }
        public bool RemoveVat { get; set; }
        public decimal? FlatAdjustment { get; set; }

        public virtual ICollection<InsurancePricing> InsurancePricings { get; set; }
    }
}
