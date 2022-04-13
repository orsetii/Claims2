using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Setting
    {
        public int BrandWeighting { get; set; }
        public int AssignmentBusyCoeff { get; set; }
        public int AssignmentCommodityCoeff { get; set; }
    }
}
