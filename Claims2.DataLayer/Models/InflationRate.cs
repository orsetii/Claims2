using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class InflationRate
    {
        public int Id { get; set; }
        public decimal Cpivalue { get; set; }
        public int Year { get; set; }
    }
}
