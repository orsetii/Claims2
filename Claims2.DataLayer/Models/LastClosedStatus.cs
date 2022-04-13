using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class LastClosedStatus
    {
        public int? LcshistoryId { get; set; }
        public int ClaimId { get; set; }
    }
}
