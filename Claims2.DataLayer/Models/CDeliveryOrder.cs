using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CDeliveryOrder
    {
        public int DoId { get; set; }
        public DateTime DoDateCreated { get; set; }
        public bool DoSent { get; set; }
        public DateTime? DoDateSent { get; set; }
        public string DoProductCode { get; set; } = null!;
        public int DoService { get; set; }
        public int DoInspectionId { get; set; }
        public DateTime DoDateDeliveryExpected { get; set; }
    }
}
