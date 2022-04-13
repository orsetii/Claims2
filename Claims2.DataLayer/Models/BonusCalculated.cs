using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BonusCalculated
    {
        public int BcId { get; set; }
        public string BcMonth { get; set; } = null!;
        public int BcClaimHandlerId { get; set; }
        public DateTime? BcDate { get; set; }
        public int BcDayOfYear { get; set; }
        public int BcWeekNo { get; set; }
        public string BcBonusType { get; set; } = null!;
        public decimal BcPeriodGp { get; set; }
        public decimal BcCalcBonus { get; set; }
        public string? BcNotes { get; set; }
        public decimal BcPeriodGpAdditional { get; set; }
        public int BcVersion { get; set; }
    }
}
