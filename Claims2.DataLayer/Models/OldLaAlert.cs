using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldLaAlert
    {
        public int LaAlertId { get; set; }
        public int LaAlertLaId { get; set; }
        public string LaAlertEmail { get; set; } = null!;
        public string LaAlertMethod { get; set; } = null!;
        public int LaAlertGroupId { get; set; }
    }
}
