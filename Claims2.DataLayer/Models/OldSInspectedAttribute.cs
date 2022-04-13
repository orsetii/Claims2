using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldSInspectedAttribute
    {
        public int SInspectedItemId { get; set; }
        public int? SItemId { get; set; }
        public int? SInspectedAttribute { get; set; }
        public string? SInspectedValue { get; set; }
        public double? NumericValue { get; set; }
    }
}
