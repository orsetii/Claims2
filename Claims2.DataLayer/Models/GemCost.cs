using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class GemCost
    {
        public int Id { get; set; }
        public int FnolvalueId { get; set; }
        public decimal LowerBound { get; set; }
        public decimal UpperBound { get; set; }
        public decimal Price { get; set; }
        public bool BoundsInCarats { get; set; }
        public int ClarityId { get; set; }
        public int? ShapeId { get; set; }
        public int? ColourId { get; set; }
    }
}
