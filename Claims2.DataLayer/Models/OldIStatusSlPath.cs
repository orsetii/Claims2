using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldIStatusSlPath
    {
        public OldIStatusSlPath()
        {
            OldIStatusSlNextActions = new HashSet<OldIStatusSlNextAction>();
        }

        public int IStatusPathId { get; set; }
        public int IStatusPathStart { get; set; }
        public int IStatusPathEnd { get; set; }
        public int IStatusPathEventType { get; set; }

        public virtual OldIStatusSlType IStatusPathEndNavigation { get; set; } = null!;
        public virtual OldIEventType IStatusPathEventTypeNavigation { get; set; } = null!;
        public virtual OldIStatusSlType IStatusPathStartNavigation { get; set; } = null!;
        public virtual ICollection<OldIStatusSlNextAction> OldIStatusSlNextActions { get; set; }
    }
}
