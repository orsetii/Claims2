using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class TempRevisedGpDate
    {
        public string? Handler { get; set; }
        public int? ClaimId { get; set; }
        public DateTime? ProfitDate { get; set; }
        public DateTime? RevisedDate { get; set; }
    }
}
