using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SagePi
    {
        public int SpiId { get; set; }
        public DateTime SpiDate { get; set; }
        public int SpiAccountingPeriod { get; set; }
        public int SpiTransPeriod { get; set; }
        public string SpiPostingType { get; set; } = null!;
        public int SpiSupplierId { get; set; }
        public string SpiTransRef { get; set; } = null!;
        public decimal SpiNetGoods { get; set; }
        public decimal SpiCarriage { get; set; }
        public int SpiPoNumber { get; set; }
        public int SpiCreatedBy { get; set; }
        public DateTime SpiCreatedOn { get; set; }
        public int? SpiEditedBy { get; set; }
        public DateTime? SpiEditedOn { get; set; }
    }
}
