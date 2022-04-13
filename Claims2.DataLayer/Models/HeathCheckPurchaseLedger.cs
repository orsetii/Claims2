using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class HeathCheckPurchaseLedger
    {
        public int PemId { get; set; }
        public decimal PemGross { get; set; }
        public decimal? OsDebits { get; set; }
        public decimal? OsCredits { get; set; }
        public decimal? PdDebits { get; set; }
        public decimal? PdCredits { get; set; }
    }
}
