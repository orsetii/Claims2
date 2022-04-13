using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldIEventType
    {
        public OldIEventType()
        {
            OldIStatusSlPaths = new HashSet<OldIStatusSlPath>();
        }

        public int IEventTypeId { get; set; }
        public string IEventTypeName { get; set; } = null!;
        public bool IEventTypeOtlu { get; set; }
        public bool IEventTypeCustomEvent { get; set; }

        public virtual ICollection<OldIStatusSlPath> OldIStatusSlPaths { get; set; }
    }
}
