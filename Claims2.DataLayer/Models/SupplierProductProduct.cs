using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SupplierProductProduct
    {
        public int ProductId { get; set; }
        public int SupplierProductId { get; set; }
        public int? ItemId { get; set; }
    }
}
