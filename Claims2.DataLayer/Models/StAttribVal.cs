using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class StAttribVal
    {
        public int StAvId { get; set; }
        public int StAvAttribId { get; set; }
        public int StAvSiId { get; set; }
        public string? StAvAttribVal { get; set; }

        public virtual StStockItem StAvSi { get; set; } = null!;
    }
}
