using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class APotentialIssue
    {
        public int PotentialIssueId { get; set; }
        public int ClaimId { get; set; }
        public int Type { get; set; }
        public DateTime Date { get; set; }
        public int ClaimsHandler { get; set; }
    }
}
