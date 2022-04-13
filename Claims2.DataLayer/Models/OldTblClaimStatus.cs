using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldTblClaimStatus
    {
        public int ClaimStatusId { get; set; }
        public string? VendorCode { get; set; }
        public string? Description { get; set; }
        public bool? DisplayOnWeb { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
