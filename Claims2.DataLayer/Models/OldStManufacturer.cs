using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldStManufacturer
    {
        public OldStManufacturer()
        {
            OldStLinkSuppMen = new HashSet<OldStLinkSuppMan>();
            OldStMeetingsMen = new HashSet<OldStMeetingsMan>();
            OldStStockItems = new HashSet<OldStStockItem>();
        }

        public int StManId { get; set; }
        public string? StManName { get; set; }
        public int StManProductTypeId { get; set; }
        public string? StManContactName { get; set; }
        public string? StManPhoneNumber { get; set; }
        public string? StManFaxNumber { get; set; }
        public string? StManEmail { get; set; }
        public string? StManAddress1 { get; set; }
        public string? StManAddress2 { get; set; }
        public string? StManPostCode { get; set; }
        public string? StManContactName2 { get; set; }
        public string? StManPhoneNumber2 { get; set; }
        public string? StManEmail2 { get; set; }
        public string? StManContactName3 { get; set; }
        public string? StManPhoneNumber3 { get; set; }
        public string? StManEmail3 { get; set; }

        public virtual OldSLTl StManProductType { get; set; } = null!;
        public virtual ICollection<OldStLinkSuppMan> OldStLinkSuppMen { get; set; }
        public virtual ICollection<OldStMeetingsMan> OldStMeetingsMen { get; set; }
        public virtual ICollection<OldStStockItem> OldStStockItems { get; set; }
    }
}
