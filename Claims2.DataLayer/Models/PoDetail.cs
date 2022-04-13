using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class PoDetail
    {
        public int PodId { get; set; }
        public int PodPomId { get; set; }
        public int? PodPimId { get; set; }
        public int PodClaimOrderId { get; set; }
        public int PodQuantity { get; set; }
        public decimal PodOrderCostEach { get; set; }
        public int PodVrId { get; set; }
        public int PodVtId { get; set; }
        public decimal PodOrderCarriage { get; set; }
        public decimal? PodInvCostEach { get; set; }
        public decimal? PodInvCarriage { get; set; }
        public int? PodNlaId { get; set; }
    }
}
