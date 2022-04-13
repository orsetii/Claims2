using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class AttributeCategory
    {
        public int Id { get; set; }
        public string Category { get; set; } = null!;
    }
}
