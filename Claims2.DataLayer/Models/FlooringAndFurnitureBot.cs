using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class FlooringAndFurnitureBot
    {
        public int Id { get; set; }
        public int InsuranceClaimId { get; set; }
        public string Question { get; set; } = null!;
        public int QuestionId { get; set; }
        public string? ItemName { get; set; }
        public bool? IsItFurniture { get; set; }
        public int? PerilId { get; set; }
    }
}
