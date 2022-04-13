using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ExtendedFamilyAttributeValue
    {
        public int Id { get; set; }
        public int ExtendedFamilyId { get; set; }
        public int AttributeId { get; set; }
        public int ValueId { get; set; }
    }
}
