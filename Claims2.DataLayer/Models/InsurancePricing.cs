using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class InsurancePricing
    {
        public int FlInsurancePricingId { get; set; }
        public int InsurerId { get; set; }
        public int PricingTypeId { get; set; }

        public virtual InsuranceCompany Insurer { get; set; } = null!;
        public virtual InsurancePricingType PricingType { get; set; } = null!;
    }
}
