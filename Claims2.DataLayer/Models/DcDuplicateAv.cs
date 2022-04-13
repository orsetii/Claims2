using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class DcDuplicateAv
    {
        public int AttributeId { get; set; }
        public string AttributeName { get; set; } = null!;
        public string ValueName { get; set; } = null!;
        public int? Count { get; set; }
        public int? MinValueId { get; set; }
        public double? MaxWeighting { get; set; }
        public double? MinWeighting { get; set; }
    }
}
