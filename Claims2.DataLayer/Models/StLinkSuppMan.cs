using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class StLinkSuppMan
    {
        public int StLinkId { get; set; }
        public int StLinkSuppId { get; set; }
        public int StLinkManId { get; set; }

        public virtual StManufacturer StLinkMan { get; set; } = null!;
        public virtual StSupplier StLinkSupp { get; set; } = null!;
    }
}
