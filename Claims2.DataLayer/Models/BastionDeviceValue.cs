using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BastionDeviceValue
    {
        public int ItemId { get; set; }
        public string Type { get; set; } = null!;
        public string Make { get; set; } = null!;
        public string Name { get; set; } = null!;
        public double Price { get; set; }
        public DateTime StartDate { get; set; }
        public string? Updated { get; set; }
    }
}
