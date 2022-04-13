using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ExternalProduct
    {
        public int ProductId { get; set; }
        public string? AliasProductId { get; set; }
        public string? VendorCode { get; set; }
        public string ProductCode { get; set; } = null!;
        public string? SageProductCode { get; set; }
        public string Description { get; set; } = null!;
        public int ProductType { get; set; }
        public string PurchaseNominalCode { get; set; } = null!;
        public string SalesNominalCode { get; set; } = null!;
        public string? DetailedDescription1 { get; set; }
        public string? DetailedDescription2 { get; set; }
        public string? DetailedDescription3 { get; set; }
        public string? DetailedDescription4 { get; set; }
        public string? DetailedDescription5 { get; set; }
        public string? DetailedDescription6 { get; set; }
        public string? DetailedDescription7 { get; set; }
        public string? DetailedDescription8 { get; set; }
        public string? DetailedDescription9 { get; set; }
        public string? DetailedDescription10 { get; set; }
        public string? DetailedDescription11 { get; set; }
        public string? DetailedDescription12 { get; set; }
        public string? DetailedDescription13 { get; set; }
        public string? DetailedDescription14 { get; set; }
        public string? DetailedDescription15 { get; set; }
        public string? DetailedDescription16 { get; set; }
        public string? DetailedDescription17 { get; set; }
        public string? DetailedDescription18 { get; set; }
        public string? DetailedDescription19 { get; set; }
        public string? DetailedDescription20 { get; set; }
        public decimal BuyRate { get; set; }
        public decimal SellRate { get; set; }
        public bool Deleted { get; set; }
        public bool Synchronized { get; set; }
        public DateTime? DateSynchronized { get; set; }
        public DateTime? LastSynchronized { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public DateTime LastUpdated { get; set; }
        public bool UsedFrequently { get; set; }
        public bool UnlistedProduct { get; set; }
        public string? Category { get; set; }
        public string? Make { get; set; }
        public bool QualifiedProduct { get; set; }
        public decimal RetailPrice { get; set; }
        public string? SuperceededBy { get; set; }
        public DateTime? SuperceededDate { get; set; }
        public string? SuperceededComments { get; set; }
        public int? SbsproductId { get; set; }
        public int DataProviderId { get; set; }
    }
}
