using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CycleValue
    {
        public int Id { get; set; }
        public int CycleId { get; set; }
        public int ParameterId { get; set; }
        public int? ValueId { get; set; }
        public string? Value { get; set; }

        public virtual Cycle Cycle { get; set; } = null!;
    }
}
