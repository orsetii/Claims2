using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CarpetrightVouchersInfo
    {
        public int? OrderId { get; set; }
        public decimal? Value { get; set; }
        public string? Pan { get; set; }
        public string? Serial { get; set; }
        public string? Pin { get; set; }
        public string? Url { get; set; }
    }
}
