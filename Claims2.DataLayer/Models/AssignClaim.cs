using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class AssignClaim
    {
        public int AssignClaimId { get; set; }
        public int? UserId { get; set; }
        public string? UserName { get; set; }
        public int? DeliveryAdviceId { get; set; }
        public int? DeliveryAdviceItemId { get; set; }
        public int? ItemId { get; set; }
        public string? ItemNumber { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
