using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class TempWatch
    {
        public double? ProductCode { get; set; }
        public string? ProductType { get; set; }
        public string? Description { get; set; }
        public string? Recipent { get; set; }
        public double? CostPrice { get; set; }
        public double? Rrp { get; set; }
        public string? Manufacturer { get; set; }
        public string? MovementType { get; set; }
        public string? DialColour { get; set; }
        public string? StrapMaterial { get; set; }
        public string? CaseMaterial { get; set; }
        public string? CaseDiameter { get; set; }
        public string? WatchMarkers { get; set; }
        public string? Image { get; set; }
    }
}
