using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class HistoricalMetalCost
    {
        public int Id { get; set; }
        public decimal PricePerGram { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int? MetalId { get; set; }
    }
}
