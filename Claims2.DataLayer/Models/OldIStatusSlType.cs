using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldIStatusSlType
    {
        public OldIStatusSlType()
        {
            OldIStatusSlNextActions = new HashSet<OldIStatusSlNextAction>();
            OldIStatusSlPathIStatusPathEndNavigations = new HashSet<OldIStatusSlPath>();
            OldIStatusSlPathIStatusPathStartNavigations = new HashSet<OldIStatusSlPath>();
        }

        public int ISSlTypeId { get; set; }
        public string ISSlTypeName { get; set; } = null!;
        public int ISSlTypeTl { get; set; }
        public int ISSlTypeTime { get; set; }
        public bool ISSlTypeCloses { get; set; }
        public bool ISSlMiClosed { get; set; }
        public int? MiCat { get; set; }

        public virtual ICollection<OldIStatusSlNextAction> OldIStatusSlNextActions { get; set; }
        public virtual ICollection<OldIStatusSlPath> OldIStatusSlPathIStatusPathEndNavigations { get; set; }
        public virtual ICollection<OldIStatusSlPath> OldIStatusSlPathIStatusPathStartNavigations { get; set; }
    }
}
