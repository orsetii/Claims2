using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class InvoiceDetailFinance
    {
        public int Id { get; set; }
        public int? InsuranceClaimId { get; set; }
        public int? InvoiceMasterId { get; set; }
        public int? InvoiceDetailId { get; set; }
        public int? StockCode { get; set; }
        public double? Net { get; set; }
        public double? Gross { get; set; }
    }
}
