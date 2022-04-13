using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Cycle
    {
        public Cycle()
        {
            CycleValues = new HashSet<CycleValue>();
        }

        public int CycleId { get; set; }
        public string? ItemNumber { get; set; }
        public string? VariantCode { get; set; }
        public string? ItemCode { get; set; }
        public int? BrandId { get; set; }
        public string? Description { get; set; }
        public string? WebDescription { get; set; }
        public string? InformationUrl { get; set; }
        public string? EanUpcBarcode { get; set; }
        public double? CostPrice { get; set; }
        public double? WebPrice { get; set; }
        public int? Stock { get; set; }
        public int? QuantityOnOrder { get; set; }
        public string? ExpectedAvailability { get; set; }
        public string? InternalBarcode { get; set; }
        public string? PictureUrl { get; set; }
        public int? OldProductId { get; set; }

        public virtual CycleBrand? Brand { get; set; }
        public virtual ICollection<CycleValue> CycleValues { get; set; }
    }
}
