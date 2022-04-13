using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldTblWarranty
    {
        public int WarrantyId { get; set; }
        public string? Description { get; set; }
        public int UserId { get; set; }
        public int ItemTypeId { get; set; }
        public bool? DisplayOnWeb { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual OldTblItemType ItemType { get; set; } = null!;
        public virtual OldTblUser User { get; set; } = null!;
    }
}
