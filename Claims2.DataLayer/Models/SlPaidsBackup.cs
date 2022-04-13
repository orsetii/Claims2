using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SlPaidsBackup
    {
        public int SlpId { get; set; }
        public DateTime SlpDate { get; set; }
        public int SlpPemId { get; set; }
        public int SlpCustomerId { get; set; }
        public int? SlpInsCoId { get; set; }
        public int SlpAccountingPeriod { get; set; }
        public int SlpTransPeriod { get; set; }
        public string? SlpTransRef { get; set; }
        public string SlpPostingType { get; set; } = null!;
        public decimal SlpGross { get; set; }
        public int SlpAllocRef { get; set; }
        public decimal SlpAllocated { get; set; }
        public int? SlpSimId { get; set; }
        public string? SlpNotes { get; set; }
        public bool SlpDisputed { get; set; }
    }
}
