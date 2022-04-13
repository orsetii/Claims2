using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Backup
    {
        public int ProductId { get; set; }
        public int ItemId { get; set; }
        public int FamilyId { get; set; }
        public int? BrandId { get; set; }
        public string? Type { get; set; }
        public string? AltType { get; set; }
        public string? AltType2 { get; set; }
        public string? InformationUrl { get; set; }
        public string? Ean { get; set; }
        public double? AveragePrice { get; set; }
        public int? PerformanceQuartile { get; set; }
        public string? PictureUrl { get; set; }
        public string? Colour { get; set; }
        public DateTime? EncodexStart { get; set; }
        public int? DcPavcount { get; set; }
        public int? OldProductId { get; set; }
    }
}
