using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Rag
    {
        public int Id { get; set; }
        public int CommodityId { get; set; }
        public int ParameterId { get; set; }
        public int? ValueId { get; set; }
        public string Rag1 { get; set; } = null!;
        public string? Operator { get; set; }
        public int? Value { get; set; }
        public bool? GreenIfManMade { get; set; }
    }
}
