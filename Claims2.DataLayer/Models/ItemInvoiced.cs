using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ItemInvoiced
    {
        public int IiId { get; set; }
        public int IiClaimOrderId { get; set; }
    }
}
