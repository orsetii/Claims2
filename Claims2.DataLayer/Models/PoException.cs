using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class PoException
    {
        public int PoeId { get; set; }
        public int PoePomId { get; set; }
        public int PoeClaimId { get; set; }
        public int PoeTypeId { get; set; }
        public DateTime PoeDateCreated { get; set; }
        public int PoeCreatedBy { get; set; }
        public string? PoeDescription { get; set; }
        public decimal? PoeOldGoodsCost { get; set; }
        public decimal? PoeNewGoodsCost { get; set; }
        public decimal? PoeOldCarriage { get; set; }
        public decimal? PoeNewCarriage { get; set; }
        public DateTime? PoeOldEstDate { get; set; }
        public DateTime? PoeNewEstDate { get; set; }
        public DateTime? PoeOldConfirmedDate { get; set; }
        public DateTime? PoeNewConfirmedDate { get; set; }
    }
}
