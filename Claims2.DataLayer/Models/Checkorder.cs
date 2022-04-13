using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Checkorder
    {
        public int ClaimOrderId { get; set; }
        public string? VendorCode { get; set; }
        public int InsuranceClaimId { get; set; }
        public string ShortDescription { get; set; } = null!;
        public int ItemTypeId { get; set; }
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public int CancelledQuantity { get; set; }
        public int OrderedQuantity { get; set; }
    }
}
