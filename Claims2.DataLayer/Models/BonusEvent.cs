using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BonusEvent
    {
        public int BeId { get; set; }
        public int BeUserId { get; set; }
        public string BeMonth { get; set; } = null!;
        public int BeCalcVersion { get; set; }
        public DateTime BeCalcDate { get; set; }
    }
}
