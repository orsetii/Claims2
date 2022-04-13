using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class InvoiceException
    {
        public int IeId { get; set; }
        public int IeProductId { get; set; }
        public int IeVrId { get; set; }
        public bool IeCashSettlement { get; set; }
    }
}
