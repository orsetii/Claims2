using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CsvUploadedStockDelivered
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
        public int CsvPoNumber { get; set; }
        public DateTime CsvDateDelivered { get; set; }
        public decimal CsvNetCost { get; set; }
    }
}
