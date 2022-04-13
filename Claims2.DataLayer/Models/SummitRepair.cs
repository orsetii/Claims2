using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SummitRepair
    {
        public int MiId { get; set; }
        public string? MiCatDesc { get; set; }
        public string? Openx { get; set; }
        public string? Consignment { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime? InvoiceDate { get; set; }
        public int? MiCat { get; set; }
        public bool Closed { get; set; }
    }
}
