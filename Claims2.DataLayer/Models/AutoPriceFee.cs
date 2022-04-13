using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class AutoPriceFee
    {
        public int ApfId { get; set; }
        public int ApfInsuranceCoId { get; set; }
        public string ApfBasis { get; set; } = null!;
        /// <summary>
        /// Variable, Fixed or Marku+fixed element (V/F/M)
        /// </summary>
        public string? ApfNarrative { get; set; }
        public decimal? ApfFixedPrice { get; set; }
        public decimal? ApfMarkUp { get; set; }
        public int ApfProductId { get; set; }
        public DateTime ApfEffectiveFrom { get; set; }
        public DateTime? ApfEffectiveTo { get; set; }
    }
}
