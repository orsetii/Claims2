using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BastionImei
    {
        public int ImeiId { get; set; }
        public int ClaimId { get; set; }
        public string Guid { get; set; } = null!;
        public bool IsImei { get; set; }
        public string Number { get; set; } = null!;
        public DateTime ImeiDate { get; set; }
    }
}
