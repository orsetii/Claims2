using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class LgBordereau
    {
        public int LgbId { get; set; }
        public string LgbLaRef { get; set; } = null!;
        public string? LgbPostcode { get; set; }
        public decimal LgbGross { get; set; }
        public string LgbFeeCon { get; set; } = null!;
        public int LgbInvNo { get; set; }
        public string LgbFI { get; set; } = null!;
        public string LgbExcessFlag { get; set; } = null!;
        public decimal LgbExcess { get; set; }
        public int LgbSimId { get; set; }
        public DateTime LgbDate { get; set; }
    }
}
