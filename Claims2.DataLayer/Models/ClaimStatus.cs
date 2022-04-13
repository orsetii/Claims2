using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ClaimStatus
    {
        public int CsId { get; set; }
        public int CsClaimId { get; set; }
        public int CsCstId { get; set; }
        public string? CsNotes { get; set; }
    }
}
