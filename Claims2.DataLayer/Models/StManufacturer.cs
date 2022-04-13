using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class StManufacturer
    {
        public StManufacturer()
        {
            StLinkSuppMen = new HashSet<StLinkSuppMan>();
            StMeetingsMen = new HashSet<StMeetingsMan>();
            StStockItems = new HashSet<StStockItem>();
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

        public virtual SLTl1 StManProductType { get; set; } = null!;
        public virtual ICollection<StLinkSuppMan> StLinkSuppMen { get; set; }
        public virtual ICollection<StMeetingsMan> StMeetingsMen { get; set; }
        public virtual ICollection<StStockItem> StStockItems { get; set; }
    }
}
