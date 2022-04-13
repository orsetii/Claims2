using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class TblClaimType
    {
        public int ClaimTypeId { get; set; }
        public string ClaimTypeDescription { get; set; } = null!;
    }
}
