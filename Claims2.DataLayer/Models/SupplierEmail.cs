using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SupplierEmail
    {
        public int SeId { get; set; }
        public int SupplierId { get; set; }
        public string EmailAddress { get; set; } = null!;
    }
}
