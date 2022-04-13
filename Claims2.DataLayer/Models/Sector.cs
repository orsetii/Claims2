using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Sector
    {
        public int SectorId { get; set; }
        public string SectorName { get; set; } = null!;
        public int GfksectorId { get; set; }
        public string? OldCategoryName { get; set; }
    }
}
