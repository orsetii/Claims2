using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class DcBestDefinedProduct
    {
        public int? BestProductId { get; set; }
        public string? Type { get; set; }
        public int? BrandId { get; set; }
        public int FamilyId { get; set; }
        public int? Pavcount { get; set; }
    }
}
