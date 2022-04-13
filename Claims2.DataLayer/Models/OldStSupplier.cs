using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldStSupplier
    {
        public OldStSupplier()
        {
            OldStLinkSuppMen = new HashSet<OldStLinkSuppMan>();
            OldStStockRecords = new HashSet<OldStStockRecord>();
        }

        public int StSuppId { get; set; }
        public string? StSuppName { get; set; }
        public string? StSuppContactName { get; set; }
        public string? StSuppPhoneNumber { get; set; }
        public string? StSuppFaxNumber { get; set; }
        public string? StSuppEmail { get; set; }
        public string? StSuppAddress1 { get; set; }
        public string? StSuppAddress2 { get; set; }
        public string? StSuppPostCode { get; set; }
        public int StSuppProductTypeId { get; set; }
        public string? StSuppContactName2 { get; set; }
        public string? StSuppPhoneNumber2 { get; set; }
        public string? StSuppEmail2 { get; set; }
        public string? StSuppContactName3 { get; set; }
        public string? StSuppPhoneNumber3 { get; set; }
        public string? StSuppEmail3 { get; set; }
        public int? StSuppSageCode { get; set; }

        public virtual ICollection<OldStLinkSuppMan> OldStLinkSuppMen { get; set; }
        public virtual ICollection<OldStStockRecord> OldStStockRecords { get; set; }
    }
}
