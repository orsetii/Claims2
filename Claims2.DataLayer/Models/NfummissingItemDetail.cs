using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NfummissingItemDetail
    {
        public string ClaimNumber { get; set; } = null!;
        public string ItemGuid { get; set; } = null!;
        public string SbsinstructionUidNfum { get; set; } = null!;
        public int ClaimCenterReference { get; set; }
        public string SuggestedFulfilment { get; set; } = null!;
    }
}
