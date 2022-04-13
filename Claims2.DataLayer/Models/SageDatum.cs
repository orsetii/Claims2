using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SageDatum
    {
        public string? Acc { get; set; }
        public string? AccName { get; set; }
        public double? InvNo { get; set; }
        public DateTime? InvDate { get; set; }
        public string? RecType { get; set; }
        public double? SbsRef { get; set; }
        public string? StockCode { get; set; }
        public string? Details { get; set; }
        public string? Qty { get; set; }
        public double? Net { get; set; }
        public string? Tax { get; set; }
        public double? Gross { get; set; }
        public double? Calc1 { get; set; }
        public double? Calc2 { get; set; }
        public double? Calc3 { get; set; }
        public double? Carriagenet { get; set; }
        public double? Carriagetax { get; set; }
        public double? CarriageGross { get; set; }
        public double? InvNet { get; set; }
        public double? InvTax { get; set; }
        public double? InvGross { get; set; }
    }
}
