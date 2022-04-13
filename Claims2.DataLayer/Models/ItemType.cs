using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ItemType
    {
        public ItemType()
        {
            Item1s = new HashSet<Item1>();
            Warranties = new HashSet<Warranty>();
        }

        public int ItemTypeId { get; set; }
        public string? Description { get; set; }
        public bool? DisplayOnWeb { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public int? FnolvalueId { get; set; }

        public virtual ICollection<Item1> Item1s { get; set; }
        public virtual ICollection<Warranty> Warranties { get; set; }
    }
}
