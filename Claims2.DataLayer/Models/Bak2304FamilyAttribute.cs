using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Bak2304FamilyAttribute
    {
        public int Id { get; set; }
        public int FamilyId { get; set; }
        public int AttributeId { get; set; }
        public int Relevancy { get; set; }
        public double Weighting { get; set; }
        public string FilterType { get; set; } = null!;
        public int? FilterTypeId { get; set; }
        public double? Tolerance { get; set; }
    }
}
