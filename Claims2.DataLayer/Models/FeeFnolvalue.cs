using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class FeeFnolvalue
    {
        public int Id { get; set; }
        public int FeeId { get; set; }
        public int AttributeId { get; set; }
        public int ValueId { get; set; }
    }
}
