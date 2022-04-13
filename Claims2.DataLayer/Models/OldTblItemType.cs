﻿using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldTblItemType
    {
        public OldTblItemType()
        {
            OldTblItems = new HashSet<OldTblItem>();
            OldTblWarranties = new HashSet<OldTblWarranty>();
        }

        public int ItemTypeId { get; set; }
        public string? Description { get; set; }
        public bool? DisplayOnWeb { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public int? FnolvalueId { get; set; }

        public virtual ICollection<OldTblItem> OldTblItems { get; set; }
        public virtual ICollection<OldTblWarranty> OldTblWarranties { get; set; }
    }
}