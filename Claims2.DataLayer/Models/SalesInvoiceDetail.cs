using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SalesInvoiceDetail
    {
        public int SidId { get; set; }
        public int SidSimId { get; set; }
        public int? SidClaimOrderId { get; set; }
        public int? SidSieId { get; set; }
        public int? SidItemCode { get; set; }
        public string? SidItemName { get; set; }
        public int SidQuantity { get; set; }
        public decimal SidPriceEach { get; set; }
        public decimal SidCostEach { get; set; }
        public int? SidItemtypeId { get; set; }
        public int SidVrId { get; set; }
        public bool SidHideItem { get; set; }
        public int SidNlaId { get; set; }
        public int? SidBcId { get; set; }
        public decimal SidVat { get; set; }
    }
}
