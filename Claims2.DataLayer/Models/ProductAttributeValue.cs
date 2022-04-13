using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ProductAttributeValue
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int AttributeId { get; set; }
        public int? ValueId { get; set; }
        public double? Value { get; set; }
    }
}
