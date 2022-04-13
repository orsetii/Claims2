using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class StockCodeException
    {
        public string? OldMidesc { get; set; }
        public string? StockCode { get; set; }
        public int? ProductId { get; set; }
        public int? FinanceTypeId { get; set; }
    }
}
