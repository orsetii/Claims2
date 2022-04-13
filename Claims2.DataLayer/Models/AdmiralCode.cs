using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class AdmiralCode
    {
        public int AcId { get; set; }
        public string Code { get; set; } = null!;
        public int? FnolValue { get; set; }
    }
}
