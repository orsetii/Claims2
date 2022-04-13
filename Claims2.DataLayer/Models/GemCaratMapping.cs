using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class GemCaratMapping
    {
        public int Id { get; set; }
        public int GemTypeId { get; set; }
        public int? GemCutId { get; set; }
        public int GemDimensionsId { get; set; }
        public int? GemCaratId { get; set; }

        public virtual Value1? GemCarat { get; set; }
        public virtual Value1? GemCut { get; set; }
        public virtual Value1 GemDimensions { get; set; } = null!;
        public virtual Value1 GemType { get; set; } = null!;
    }
}
