using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Sbebdx
    {
        public int BdxId { get; set; }
        public string? ClaimId { get; set; }
        public double? NetTotal { get; set; }
        public double? Vat { get; set; }
        public string? Consignment { get; set; }
        public string? RepairType { get; set; }
        public string? RepairStatus { get; set; }
        public string? Imeiout { get; set; }
    }
}
