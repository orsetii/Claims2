using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class DcDuplicatePav
    {
        public int ProductId { get; set; }
        public int AttributeId { get; set; }
        public int? ValueId { get; set; }
        public int? Cnt { get; set; }
        public int? CorrectId { get; set; }
    }
}
