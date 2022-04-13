using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class InspectionStatus
    {
        public int InspectionStatusId { get; set; }
        public string? VendorCode { get; set; }
        public string? Description { get; set; }
        public bool? DisplayOnWeb { get; set; }
        public int? SortSequence { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
