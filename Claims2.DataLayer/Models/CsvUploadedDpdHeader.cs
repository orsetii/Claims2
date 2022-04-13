using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CsvUploadedDpdHeader
    {
        public int DpdId { get; set; }
        public string DpdInvoiceNo { get; set; } = null!;
        public DateTime DpdInvoiceDate { get; set; }
        public int DpdBatchId { get; set; }
        public decimal DpdNet { get; set; }
        public decimal DpdVat { get; set; }
        public decimal DpdGross { get; set; }
    }
}
