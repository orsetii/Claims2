using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SlDebtor
    {
        public int SldId { get; set; }
        public DateTime SldDate { get; set; }
        public int SldPemId { get; set; }
        public int SldCustomerId { get; set; }
        public int? SldInsCoId { get; set; }
        public int SldAccountingPeriod { get; set; }
        public int SldTransPeriod { get; set; }
        public string? SldTransRef { get; set; }
        public string SldPostingType { get; set; } = null!;
        public decimal SldGross { get; set; }
        public int? SldAllocRef { get; set; }
        public decimal SldBalance { get; set; }
        public string? SldNotes { get; set; }
    }
}
