using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ClaimType
    {
        public int ClaimTypeId { get; set; }
        public string ClaimTypeDescription { get; set; } = null!;
    }
}
