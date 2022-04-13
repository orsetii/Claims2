using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldCDeliveryInspCompany
    {
        public int DiId { get; set; }
        public int DiDeliveryCompId { get; set; }
        public int DiInspCompId { get; set; }
        public string DiProductCode { get; set; } = null!;
    }
}
