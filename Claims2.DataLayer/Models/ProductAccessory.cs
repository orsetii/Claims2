using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ProductAccessory
    {
        public int AccessoryId { get; set; }
        public int ParentProductId { get; set; }
        public int AccessoryProductId { get; set; }
        public string? Source { get; set; }
        public int? ParentItemId { get; set; }
        public int? AccessoryItemId { get; set; }
    }
}
