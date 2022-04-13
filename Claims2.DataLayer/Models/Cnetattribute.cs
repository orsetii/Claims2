using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Cnetattribute
    {
        public int AttributeId { get; set; }
        public string AttributeName { get; set; } = null!;
        public int? FeatureId { get; set; }
        public bool LookupValue { get; set; }
        public string? Explanation { get; set; }
        public int? Weighting { get; set; }
        public bool FewItems { get; set; }
        public string? Note { get; set; }
        public string AlternateAttributeName { get; set; } = null!;
        public int Multiplier { get; set; }
        public bool PreExisting { get; set; }
        public bool KeyValue { get; set; }
        public int? Linkedattributeid { get; set; }
        public int? DefaultValueId { get; set; }
        public int? MappedTo { get; set; }
        public int? AttributeCategoryId { get; set; }
        public string? Cnetid { get; set; }
    }
}
