using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SalesInvoiceExtra
    {
        public int SieId { get; set; }
        public int? SieLossAdjusterFlag { get; set; }
        public string? SieDescription { get; set; }
        public decimal? SieAmount { get; set; }
        public int? SieNlaId { get; set; }
        public int? SieVtId { get; set; }
        public int? SieVrId { get; set; }
    }
}
