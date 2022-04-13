using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SFixRate
    {
        public int FixRateIndex { get; set; }
        public string? FixCode { get; set; }
        public double? FixRate { get; set; }
    }
}
