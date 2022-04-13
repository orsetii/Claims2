using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CsvUploadedSupplierInvoice
    {
        public int CsvId { get; set; }
        public DateTime CsvUploadedOn { get; set; }
        public int CsvUploadedBy { get; set; }
        public DateTime? CsvEditedOn { get; set; }
        public int? CsvEditedBy { get; set; }
        public int CsvBatchId { get; set; }
        public int CsvRowNumber { get; set; }
        public int? CsvUpdated { get; set; }
        public string? CsvUpdateFailMessage { get; set; }
        public string? CsvUpdateWarning { get; set; }
        public int CsvSupplierId { get; set; }
        public int? CsvClaimRef { get; set; }
        public int? CsvPoNumber { get; set; }
        public DateTime CsvInvDate { get; set; }
        public string CsvInvNumber { get; set; } = null!;
        public decimal CsvNetGoods { get; set; }
        public decimal CsvNetCarriage { get; set; }
        public decimal CsvVat { get; set; }
        public string? CsvDiscrepancyNote { get; set; }
    }
}
