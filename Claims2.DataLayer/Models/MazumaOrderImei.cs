using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class MazumaOrderImei
    {
        public int MazumaId { get; set; }
        public int ClaimId { get; set; }
        public int PoNumber { get; set; }
        public string Imei { get; set; } = null!;
        public string Manufacturer { get; set; } = null!;
        public string Product { get; set; } = null!;
        public string ProductType { get; set; } = null!;
        public DateTime MazumaDate { get; set; }
    }
}
