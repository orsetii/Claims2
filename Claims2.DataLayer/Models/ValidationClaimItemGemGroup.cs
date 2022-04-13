using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ValidationClaimItemGemGroup
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public int TypeId { get; set; }
        public int? ShapeId { get; set; }
        public decimal Carat { get; set; }
        public int? QualityId { get; set; }
        public int SettingId { get; set; }
        public int? ColourId { get; set; }
        public int ClarityId { get; set; }
        public int? DimensionId { get; set; }
        public double? PriceUsd { get; set; }
        public DateTime? PriceLogged { get; set; }
        public double? PriceGbp { get; set; }
        public double? PriceRetailGbp { get; set; }
        public double? HistoricalPriceGbp { get; set; }
        public double? HistoricalRetailPriceGbp { get; set; }
    }
}
