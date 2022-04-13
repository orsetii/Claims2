using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class DocumentHistory
    {
        public int InspectionId { get; set; }
        public int InsuranceClaimId { get; set; }
        public DateTime Date { get; set; }
        public string Agent { get; set; } = null!;
    }
}
