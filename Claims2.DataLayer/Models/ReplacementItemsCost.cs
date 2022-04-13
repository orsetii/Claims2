using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ReplacementItemsCost
    {
        public int Id { get; set; }
        public int InspectionId { get; set; }
        public string? Room { get; set; }
        public string? Name { get; set; }
        public string? Specification { get; set; }
        public decimal? PoundPerSquareMeter { get; set; }
        public decimal? Unit { get; set; }
        public string? Dimensions { get; set; }
        public decimal? Sbscost { get; set; }
        public decimal? Rrpcost { get; set; }
        public int? SupplierId { get; set; }
        public string? SupplierName { get; set; }

        public virtual ItemInspection Inspection { get; set; } = null!;
    }
}
