using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class IEventType1
    {
        public IEventType1()
        {
            IStatusSlPath1s = new HashSet<IStatusSlPath1>();
        }

        public int IEventTypeId { get; set; }
        public string IEventTypeName { get; set; } = null!;
        public bool IEventTypeOtlu { get; set; }
        public bool IEventTypeCustomEvent { get; set; }

        public virtual ICollection<IStatusSlPath1> IStatusSlPath1s { get; set; }
    }
}
