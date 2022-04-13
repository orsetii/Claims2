using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldCDeliveryServiceCode
    {
        public int DsId { get; set; }
        public int DsDeliveryCompanyId { get; set; }
        public string DsServiceText { get; set; } = null!;
        public int DsServiceCode { get; set; }
        public int DsDateModifier { get; set; }
    }
}
