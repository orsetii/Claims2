using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SagePo
    {
        public int SpoId { get; set; }
        public DateTime SpoDate { get; set; }
        public int SpoPoNumber { get; set; }
        public int SpoSupplierId { get; set; }
        public int SpoClaimId { get; set; }
        public decimal SpoNetGoods { get; set; }
        public decimal SpoCarriage { get; set; }
    }
}
