using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BonusRate
    {
        public int BrId { get; set; }
        public string BrDwm { get; set; } = null!;
        public decimal BrThreshold { get; set; }
        public decimal BrBonus { get; set; }
    }
}
