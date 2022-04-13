using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CnetattributeValue
    {
        public int ValueId { get; set; }
        public int? AttributeId { get; set; }
        public string ValueName { get; set; } = null!;
        public int? VId { get; set; }
        public bool PreExisting { get; set; }
        public double Weighting { get; set; }
        public string? Cnetid { get; set; }
        public string? Cnetsufx { get; set; }
    }
}
