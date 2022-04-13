using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class FeeAttributeValue
    {
        public int Id { get; set; }
        public int AttributeId { get; set; }
        public int? AttributeValueId { get; set; }
        public decimal? Value { get; set; }
        public int? OperationId { get; set; }
        public int FeeId { get; set; }
    }
}
