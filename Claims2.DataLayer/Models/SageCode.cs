using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SageCode
    {
        public int SageId { get; set; }
        public int? MiCat { get; set; }
        public string? MiDesc { get; set; }
        public string? StockCode { get; set; }
    }
}
