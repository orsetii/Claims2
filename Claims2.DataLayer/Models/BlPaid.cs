using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BlPaid
    {
        public int BlpId { get; set; }
        public DateTime BlpDate { get; set; }
        public int BlpPemId { get; set; }
        public int BlpSupplierId { get; set; }
        public int? BlpOhsId { get; set; }
        public int BlpAccountingPeriod { get; set; }
        public int BlpTransPeriod { get; set; }
        public string? BlpTransRef { get; set; }
        public string BlpPostingType { get; set; } = null!;
        public decimal BlpGross { get; set; }
        public int BlpAllocRef { get; set; }
        public decimal BlpAllocated { get; set; }
        public int? BlpPimId { get; set; }
        public string? BlpNotes { get; set; }
        public bool BlpDisputed { get; set; }
    }
}
