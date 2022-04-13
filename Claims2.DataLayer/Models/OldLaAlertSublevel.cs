using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldLaAlertSublevel
    {
        public int LaAlertSlId { get; set; }
        public int LaAlertSlGroupId { get; set; }
        public string LaAlertSlTypeId { get; set; } = null!;
        public int LaAlertSlSlId { get; set; }
        public string? LaAlertSlNextAction { get; set; }
        public int? LaAlertSlNumDays { get; set; }
    }
}
