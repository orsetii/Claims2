using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class WheeliesAttributeValue
    {
        public int Id { get; set; }
        public int AttributeId { get; set; }
        public string WheeliesValue { get; set; } = null!;
        public int AttributeValueId { get; set; }
    }
}
