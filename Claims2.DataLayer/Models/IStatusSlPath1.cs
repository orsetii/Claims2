using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class IStatusSlPath1
    {
        public IStatusSlPath1()
        {
            IStatusSlNextAction1s = new HashSet<IStatusSlNextAction1>();
        }

        public int IStatusPathId { get; set; }
        public int IStatusPathStart { get; set; }
        public int IStatusPathEnd { get; set; }
        public int IStatusPathEventType { get; set; }

        public virtual IStatusSlType1 IStatusPathEndNavigation { get; set; } = null!;
        public virtual IEventType1 IStatusPathEventTypeNavigation { get; set; } = null!;
        public virtual IStatusSlType1 IStatusPathStartNavigation { get; set; } = null!;
        public virtual ICollection<IStatusSlNextAction1> IStatusSlNextAction1s { get; set; }
    }
}
