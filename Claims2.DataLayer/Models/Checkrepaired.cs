using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Checkrepaired
    {
        public int? SOutcome { get; set; }
        public int SOutcomeId { get; set; }
        public string? Expr1 { get; set; }
        public int SInspectionId { get; set; }
        public int? SInspItem { get; set; }
        public string? SInspCoDesc { get; set; }
        public int? SInspSupplierId { get; set; }
    }
}
