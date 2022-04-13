using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ReplacementItem
    {
        public int ReplacementId { get; set; }
        public int ClaimItemId { get; set; }
        public int ProductId { get; set; }
        public int? ProductItemId { get; set; }
        public double Match { get; set; }
        public DateTime DateSaved { get; set; }
        public double? LowestSupplierPrice { get; set; }
        public int? SupplierStock { get; set; }
        public string? Supplier { get; set; }

        public virtual ClaimItem2 ClaimItem { get; set; } = null!;
    }
}
