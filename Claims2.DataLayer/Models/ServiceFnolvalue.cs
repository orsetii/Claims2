using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ServiceFnolvalue
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int AttributeId { get; set; }
        public int ValueId { get; set; }
    }
}
