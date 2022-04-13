using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class IEventType
    {
        public int IEventTypeId { get; set; }
        public string IEventTypeName { get; set; } = null!;
        public bool IEventTypeOtlu { get; set; }
        public bool IEventTypeCustomEvent { get; set; }
    }
}
