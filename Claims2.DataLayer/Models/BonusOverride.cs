using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BonusOverride
    {
        public int BoId { get; set; }
        public decimal BoMinPerWeek { get; set; }
        public decimal BoMinPerMonth { get; set; }
    }
}
