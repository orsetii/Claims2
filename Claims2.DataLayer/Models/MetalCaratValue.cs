using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class MetalCaratValue
    {
        public int Id { get; set; }
        public int CaratId { get; set; }
        public double PercentValue { get; set; }
    }
}
