using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BastionExcess
    {
        public int ExcessId { get; set; }
        public int ClaimId { get; set; }
        public string? Guid { get; set; }
        public DateTime ExcessDate { get; set; }
    }
}
