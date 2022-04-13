using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class HistoricalGemCost
    {
        public int Id { get; set; }
        public int GemId { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public decimal Price { get; set; }
    }
}
