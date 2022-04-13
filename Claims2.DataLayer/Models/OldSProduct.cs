using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldSProduct
    {
        public int SProductType { get; set; }
        public string? SProductDesc { get; set; }
        public string? SProductCreatedBy { get; set; }
        public DateTime? SProductCreatedOn { get; set; }
        public int? SOldClaimCode { get; set; }
    }
}
