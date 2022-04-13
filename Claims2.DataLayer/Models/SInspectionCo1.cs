using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SInspectionCo1
    {
        public int SInspCo { get; set; }
        public string? SInspCoDesc { get; set; }
        public int? SInspUserId { get; set; }
        public int? SInspSupplierId { get; set; }
        public int SInspCompanyType { get; set; }
    }
}
