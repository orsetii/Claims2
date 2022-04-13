using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CsvUploadedNfuBanking
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
        public DateTime CsvBankingDate { get; set; }
        public string CsvBankingRef { get; set; } = null!;
        public int CsvClaimId { get; set; }
        public string CsvInvoice { get; set; } = null!;
        public decimal CsvAmount { get; set; }
        public string? CsvLossAdjuster { get; set; }
        public int? CsvLossAdjusterId { get; set; }
        public string? CsvLossAdjusterName { get; set; }
    }
}
