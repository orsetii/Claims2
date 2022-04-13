using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class GemMargin
    {
        public int Id { get; set; }
        public int ShapeId { get; set; }
        public int? GemId { get; set; }
        public int? QualityId { get; set; }
        public double? CaratLowerBound { get; set; }
        public double? CaratUpperBound { get; set; }
        public double? Margin { get; set; }
    }
}
