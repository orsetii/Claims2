using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class GenfixReplace
    {
        public string? Consignment { get; set; }
        public double? Thisval { get; set; }
        public string? Idate { get; set; }
        public string? AccountRef { get; set; }
        public int? Replaceitems { get; set; }
    }
}
