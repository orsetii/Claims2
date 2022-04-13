using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CDeliveryServiceCode
    {
        public int DsId { get; set; }
        public int DsDeliveryCompanyId { get; set; }
        public string DsServiceText { get; set; } = null!;
        public int DsServiceCode { get; set; }
        public int DsDateModifier { get; set; }
        public int? DsParentSupplierServiceId { get; set; }
        public int? DsAdditionalSupplierServiceId { get; set; }
        public bool? DsDefault { get; set; }
        public bool DsOveridingService { get; set; }
    }
}
