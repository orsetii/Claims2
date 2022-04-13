using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BlUnpaid
    {
        public int BluId { get; set; }
        public DateTime BluDate { get; set; }
        public int BluPemId { get; set; }
        public int BluSupplierId { get; set; }
        public int? BluOhsId { get; set; }
        public int BluAccountingPeriod { get; set; }
        public int BluTransPeriod { get; set; }
        public string? BluTransRef { get; set; }
        public string BluPostingType { get; set; } = null!;
        public decimal BluGross { get; set; }
        public int? BluAllocRef { get; set; }
        public decimal BluBalance { get; set; }
        public decimal BluAllocated { get; set; }
        public int? BluPimId { get; set; }
        public string? BluNotes { get; set; }
        public bool BluDisputed { get; set; }
    }
}
