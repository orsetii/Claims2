using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SimpleBrand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; } = null!;
        public int FamilyId { get; set; }
        public int? Count { get; set; }
    }
}
