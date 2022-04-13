using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Useage
    {
        public int Id { get; set; }
        public string Use { get; set; } = null!;
        public string Who { get; set; } = null!;
        public DateTime When { get; set; }
        public int? ValidationClaimId { get; set; }
        public string? SearchString { get; set; }
        public int? FamilyId { get; set; }
        public string? FamilyName { get; set; }
        public int? CommodityId { get; set; }
        public string? CommodityName { get; set; }
    }
}
