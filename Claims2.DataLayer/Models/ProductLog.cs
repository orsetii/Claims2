using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ProductLog
    {
        public int LogId { get; set; }
        public int? ProductId { get; set; }
        public string? Operation { get; set; }
    }
}
