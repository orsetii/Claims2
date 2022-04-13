using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class TempEarring
    {
        public double? ProductCode { get; set; }
        public string? ProductType { get; set; }
        public string? Description { get; set; }
        public string? Recipent { get; set; }
        public double? CostPrice { get; set; }
        public double? Rrp { get; set; }
        public string? Manufacturer { get; set; }
        public string? EarringStyle { get; set; }
        public double? DiamondCarat { get; set; }
        public string? BirthStone { get; set; }
        public string? DiamondClarity { get; set; }
        public string? DiamondColour { get; set; }
        public double? GoldCarat { get; set; }
        public string? Material { get; set; }
        public string? Image { get; set; }
    }
}
