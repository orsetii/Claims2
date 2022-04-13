using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Nfumagency
    {
        public int AgencyId { get; set; }
        public string AgencyType { get; set; } = null!;
        public bool Active { get; set; }
        public int RegionId { get; set; }
        public int AgencyCode { get; set; }
        public string Location { get; set; } = null!;
        public int? AgencyRef { get; set; }
    }
}
