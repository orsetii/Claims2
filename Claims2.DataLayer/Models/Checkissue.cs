using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Checkissue
    {
        public int SInspectionId { get; set; }
        public int? SInspItem { get; set; }
        public int? SInsuranceclaimid { get; set; }
        public string? SStatusDesc { get; set; }
        public int? SOutcome { get; set; }
        public int? SStatus { get; set; }
        public int? SSupplierid { get; set; }
        public string? SInspCoDesc { get; set; }
    }
}
