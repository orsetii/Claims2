using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ComplaintStatus
    {
        public int ComplaintStatusId { get; set; }
        public string? VendorCode { get; set; }
        public string Description { get; set; } = null!;
        public bool? DisplayOnWeb { get; set; }
        public int? SortSequence { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; } = null!;
        public DateTime DateModified { get; set; }
    }
}
