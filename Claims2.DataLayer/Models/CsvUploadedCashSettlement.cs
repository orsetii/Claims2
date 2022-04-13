using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CsvUploadedCashSettlement
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
        public int CsvClaimId { get; set; }
        public decimal? CsvExcess { get; set; }
        public int CsvPoNumber { get; set; }
        public DateTime CsvDatePaid { get; set; }
        public decimal CsvAmountPaid { get; set; }
        public string? CsvChequeNumber { get; set; }
        public string? CsvBacsRef { get; set; }
        public string CsvPaidTo { get; set; } = null!;
        public string CsvSalutation { get; set; } = null!;
    }
}
