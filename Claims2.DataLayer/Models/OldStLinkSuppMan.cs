using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldStLinkSuppMan
    {
        public int StLinkId { get; set; }
        public int StLinkSuppId { get; set; }
        public int StLinkManId { get; set; }

        public virtual OldStManufacturer StLinkMan { get; set; } = null!;
        public virtual OldStSupplier StLinkSupp { get; set; } = null!;
    }
}
