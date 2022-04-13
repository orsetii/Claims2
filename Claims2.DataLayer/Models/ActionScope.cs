using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ActionScope
    {
        public int Id { get; set; }
        public int? FaultTypeId { get; set; }
        public int? CommodityId { get; set; }
        public bool? Technical { get; set; }
        public int ActionId { get; set; }
        public int? Hours { get; set; }
    }
}
