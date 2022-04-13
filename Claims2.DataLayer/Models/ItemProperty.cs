using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ItemProperty
    {
        public int PropertyId { get; set; }
        public string PropertyText { get; set; } = null!;
        public int? ParentParameterId { get; set; }
        public int? ParentValueId { get; set; }
    }
}
