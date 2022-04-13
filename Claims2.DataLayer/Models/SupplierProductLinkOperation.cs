using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SupplierProductLinkOperation
    {
        public int ProductItemId { get; set; }
        public string SupplierProductCode { get; set; } = null!;
        public string LinkOperation { get; set; } = null!;
    }
}
