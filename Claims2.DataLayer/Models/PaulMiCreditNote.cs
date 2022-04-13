using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class PaulMiCreditNote
    {
        public int InsuranceClaimId { get; set; }
        public int? InvoiceNumber { get; set; }
        public int ItemTypeId { get; set; }
        public string? Description { get; set; }
        public string? AccountRef { get; set; }
        public string AccountName { get; set; } = null!;
        public DateTime DateInstructed { get; set; }
        public double? InvoiceGross { get; set; }
        public short? InvoiceTypeCode { get; set; }
        public string? StockCode { get; set; }
        public double? GrossAmount { get; set; }
        public int? MiCat { get; set; }
        public string? MiDesc { get; set; }
        public decimal? ClaimValue { get; set; }
        public string? UserName { get; set; }
    }
}
