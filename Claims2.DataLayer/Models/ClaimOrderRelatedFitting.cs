using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ClaimOrderRelatedFitting
    {
        public int FlRelatedfittingsId { get; set; }
        public int FlooringClaimorderid { get; set; }
        public int FittingClaimorderid { get; set; }

        public virtual ClaimOrder FittingClaimorder { get; set; } = null!;
        public virtual ClaimOrder FlooringClaimorder { get; set; } = null!;
    }
}
