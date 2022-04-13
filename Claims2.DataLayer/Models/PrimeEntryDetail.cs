using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class PrimeEntryDetail
    {
        public int PedId { get; set; }
        public int PedPemId { get; set; }
        public int PedNlcode { get; set; }
        public decimal PedAmount { get; set; }
        public int PedVatCode { get; set; }
    }
}
