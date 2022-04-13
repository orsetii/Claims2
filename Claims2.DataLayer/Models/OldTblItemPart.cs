using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldTblItemPart
    {
        public int ItemPartId { get; set; }
        public int ItemId { get; set; }
        public string? Type { get; set; }
        public string? PartNumber { get; set; }
        public string? Description { get; set; }
        public string? SupplierName { get; set; }
        public int? Quantity { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? SalesPrice { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual OldTblItem Item { get; set; } = null!;
    }
}
