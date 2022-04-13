using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class RepDescNew
    {
        public int MiRepId { get; set; }
        public string? MiRepType { get; set; }
        public string? MiRepDesc { get; set; }
        public int? MiRepSort { get; set; }
        public string? MiRepPlev { get; set; }
        public string? MiRepTarget { get; set; }
        public int? MiRepPlhours { get; set; }
        public int? FilterDd { get; set; }
    }
}
