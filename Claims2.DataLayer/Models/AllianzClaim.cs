using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class AllianzClaim
    {
        public int Id { get; set; }
        public string AllianzClaimId { get; set; } = null!;
        public int? SbsclaimId { get; set; }
        public string? Status { get; set; }
        public int? DeviceId { get; set; }
    }
}
