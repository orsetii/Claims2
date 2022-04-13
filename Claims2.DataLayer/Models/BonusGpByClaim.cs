using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BonusGpByClaim
    {
        public int BgId { get; set; }
        public string BgMonth { get; set; } = null!;
        public int BgClaimId { get; set; }
        public int BgClaimHandlerId { get; set; }
        public DateTime BgDate { get; set; }
        public int BgDayOfYear { get; set; }
        public decimal BgGp { get; set; }
        public decimal BgGpAdditional { get; set; }
        public int BgVersion { get; set; }
    }
}
