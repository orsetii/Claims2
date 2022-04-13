using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class PiMaster
    {
        public int PimId { get; set; }
        public DateTime PimDate { get; set; }
        public int PimAccountingPeriod { get; set; }
        public int PimTransPeriod { get; set; }
        public string PimPostingType { get; set; } = null!;
        public int PimSupplierId { get; set; }
        public string? PimTransRef { get; set; }
        public decimal PimGross { get; set; }
        public decimal PimVat { get; set; }
        public decimal PimNet { get; set; }
        public int PimPomId { get; set; }
        public decimal PimNetDiff { get; set; }
        public decimal PimCarrDiff { get; set; }
        public string? PimDiffText { get; set; }
        public int PimCreatedBy { get; set; }
        public DateTime PimCreatedOn { get; set; }
        public int? PimEditedBy { get; set; }
        public DateTime? PimEditedOn { get; set; }
    }
}
