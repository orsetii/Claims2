using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OverheadSupplier
    {
        public int OhsId { get; set; }
        public string OhsAccountRef { get; set; } = null!;
        public string OhsName { get; set; } = null!;
        public string? OhsAddress1 { get; set; }
        public string? OhsAddress2 { get; set; }
        public string? OhsAddress3 { get; set; }
        public string? OhsAddress4 { get; set; }
        public string? OhsPostcode { get; set; }
        public string? OhsTelephone { get; set; }
        public string? OhsFax { get; set; }
        public string? OhsEmail { get; set; }
        public string? OhsContact { get; set; }
        public int OhsCreatedBy { get; set; }
        public DateTime OhsCreatedOn { get; set; }
        public int? OhsAmendedBy { get; set; }
        public DateTime? OhsAmendedOn { get; set; }
        public bool OhsDeleted { get; set; }
    }
}
