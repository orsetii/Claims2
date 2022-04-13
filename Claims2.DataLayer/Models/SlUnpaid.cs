using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SlUnpaid
    {
        public int SluId { get; set; }
        public DateTime SluDate { get; set; }
        public int SluPemId { get; set; }
        public int SluCustomerId { get; set; }
        public int? SluInsCoId { get; set; }
        public int SluAccountingPeriod { get; set; }
        public int SluTransPeriod { get; set; }
        public string? SluTransRef { get; set; }
        public string SluPostingType { get; set; } = null!;
        public decimal SluGross { get; set; }
        public int? SluAllocRef { get; set; }
        public decimal SluBalance { get; set; }
        public decimal SluAllocated { get; set; }
        public int? SluSimId { get; set; }
        public string? SluNotes { get; set; }
        public bool SluDisputed { get; set; }
    }
}
