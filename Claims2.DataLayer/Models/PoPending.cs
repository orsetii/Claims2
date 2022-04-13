using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class PoPending
    {
        public int PopId { get; set; }
        public int PopClaimOrderId { get; set; }
        public int PopOrderQuantity { get; set; }
        public int PopCancelQuantity { get; set; }
    }
}
