using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class AppSupplier
    {
        public int Id { get; set; }
        public string SupplierName { get; set; } = null!;
        public string ServiceUrl { get; set; } = null!;
        public bool HasAuthentication { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public int SupplierId { get; set; }
        public string OrderProtocal { get; set; } = null!;
    }
}
