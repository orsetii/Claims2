using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class History1
    {
        public int Id { get; set; }
        public string Product { get; set; } = null!;
        public string Price { get; set; } = null!;
        public string? Vat { get; set; }
        public string? Total { get; set; }
        public string Supplier { get; set; } = null!;
        public int ClaimItemId { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
