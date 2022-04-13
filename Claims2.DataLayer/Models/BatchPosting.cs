using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BatchPosting
    {
        public int BpId { get; set; }
        public DateTime? BpDate { get; set; }
        public int? BpUserId { get; set; }
        public int? BpItems { get; set; }
        public int? BpItemsPosted { get; set; }
        public string? BpSpName { get; set; }
        public string? BpParam1 { get; set; }
        public string? BpParam2 { get; set; }
        public string? BpParam3 { get; set; }
        public string? BpParam4 { get; set; }
    }
}
