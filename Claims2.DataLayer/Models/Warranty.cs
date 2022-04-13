using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Warranty
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

        public virtual ItemType ItemType { get; set; } = null!;
        public virtual User2 User { get; set; } = null!;
    }
}
