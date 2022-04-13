using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Checkview
    {
        public int SInspItem { get; set; }
        public int? SInspType { get; set; }
        public int? SInsCompany { get; set; }
        public int? SInspSupplierId { get; set; }
        public int? SStatus { get; set; }
        public string ProductCode { get; set; } = null!;
    }
}
