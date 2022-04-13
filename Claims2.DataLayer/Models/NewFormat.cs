using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NewFormat
    {
        public int MiId { get; set; }
        public int? MiKey { get; set; }
        public string? MiDesc { get; set; }
        public string? MiType { get; set; }
        public bool? Active { get; set; }
        public int? SortOrder { get; set; }
    }
}
