using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class AmazonGiftCard
    {
        public int Id { get; set; }
        public string CreationRequestId { get; set; } = null!;
        public string Gcid { get; set; } = null!;
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; } = null!;
        public string CardNumber { get; set; } = null!;
        public int PoNumber { get; set; }
    }
}
