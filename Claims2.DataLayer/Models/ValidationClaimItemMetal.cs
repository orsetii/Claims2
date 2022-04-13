using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ValidationClaimItemMetal
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int MaterialId { get; set; }
        public int? TypeId { get; set; }
        public int CaratId { get; set; }
        public decimal? Weight { get; set; }
        public double? PriceGbp { get; set; }
        public double? PriceRetailGbp { get; set; }
        public double? HistoricalPriceGbp { get; set; }
        public double? HistoricalRetailPriceGbp { get; set; }
    }
}
