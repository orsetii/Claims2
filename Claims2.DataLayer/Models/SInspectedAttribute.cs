using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SInspectedAttribute
    {
        public int SInspectedItemId { get; set; }
        public int? SItemId { get; set; }
        public int? SInspectedAttribute1 { get; set; }
        public string? SInspectedValue { get; set; }
        public double? NumericValue { get; set; }
    }
}
