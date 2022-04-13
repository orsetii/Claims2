using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ExchangeRate
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double ExchangeRate1 { get; set; }
        public string SourceCurrency { get; set; } = null!;
    }
}
