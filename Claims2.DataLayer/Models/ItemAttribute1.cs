using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ItemAttribute1
    {
        public int ItemAttributeId { get; set; }
        public int ItemId { get; set; }
        public int? ItemTypeAttributeId { get; set; }
        public string? AttributeName { get; set; }
        public string? AttributeValue { get; set; }
        public string? InspectionAttributeValue { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
