using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ProductAttributeValue1
    {
        public int ProductAttributeValueId { get; set; }
        public int ProductId { get; set; }
        public int AttributeId { get; set; }
        public string Value { get; set; } = null!;
    }
}
