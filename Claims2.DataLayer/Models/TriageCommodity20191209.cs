using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class TriageCommodity20191209
    {
        public int Id { get; set; }
        public int TriageValueId { get; set; }
        public int CommodityValueId { get; set; }
        public int Action { get; set; }
    }
}
