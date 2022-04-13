using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class LastFewJanuaryClaimsWithoutOutcomesToGoLive
    {
        public string ClaimId { get; set; } = null!;
        public string Outcome { get; set; } = null!;
    }
}
