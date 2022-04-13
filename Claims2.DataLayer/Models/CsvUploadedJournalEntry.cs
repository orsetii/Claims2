using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CsvUploadedJournalEntry
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
        public DateTime CsvJeDate { get; set; }
        public int CsvJeDebitNlCode { get; set; }
        public int CsvJeCreditNlCode { get; set; }
        public string CsvJeDescription { get; set; } = null!;
        public decimal CsvJeAmount { get; set; }
        public string? CsvJeDebitVatTypeCode { get; set; }
        public string? CsvJeCreditVatTypeCode { get; set; }
    }
}
