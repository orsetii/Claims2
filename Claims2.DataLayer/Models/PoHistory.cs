using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class PoHistory
    {
        public int Id { get; set; }
        public int? ClaimOrderId { get; set; }
        public int? Ponumber { get; set; }
        public string ShortStatus { get; set; } = null!;
        public string LongStatus { get; set; } = null!;
        public DateTime Time { get; set; }
        public string? Supplier { get; set; }
        public int? ContextId { get; set; }
    }
}
