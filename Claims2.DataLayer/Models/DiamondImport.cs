using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class DiamondImport
    {
        public int Id { get; set; }
        public string? StockNo { get; set; }
        public string? Shape { get; set; }
        public string? Lab { get; set; }
        public double? Crt { get; set; }
        public string? Color { get; set; }
        public string? Clarity { get; set; }
        public string? PerCrt { get; set; }
        public string? Disc { get; set; }
        public string? RapPrice { get; set; }
        public string? Cut { get; set; }
        public string? Pol { get; set; }
        public string? Symm { get; set; }
        public string? Girdle { get; set; }
        public string? Culet { get; set; }
        public string? Flou { get; set; }
        public string? Measur { get; set; }
        public string? Dpth { get; set; }
        public string? Tble { get; set; }
        public string? CertNo { get; set; }
        public int SupplierId { get; set; }

        public virtual Supplier Supplier { get; set; } = null!;
    }
}
