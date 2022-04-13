using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BlCreditor
    {
        public int BlcId { get; set; }
        public DateTime BlcDate { get; set; }
        public int BlcPemId { get; set; }
        public int BlcSupplierId { get; set; }
        public int BlcOhsId { get; set; }
        public int BlcAccountingPeriod { get; set; }
        public int BlcTransPeriod { get; set; }
        public string? BlcTransRef { get; set; }
        public string BlcPostingType { get; set; } = null!;
        public decimal BlcGross { get; set; }
        public int? BlcAllocRef { get; set; }
        public decimal? BlcBalance { get; set; }
        public string? BlcNotes { get; set; }
    }
}
