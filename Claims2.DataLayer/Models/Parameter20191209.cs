using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Parameter20191209
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? ParentParameterId { get; set; }
        public bool Required { get; set; }
        public bool LookUpParameter { get; set; }
        public bool ClaimLevel { get; set; }
        public int SortOrder { get; set; }
        public string? Phalias { get; set; }
    }
}
