using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CountCategory
    {
        public int? Count { get; set; }
        public string ISSlTypeName { get; set; } = null!;
    }
}
