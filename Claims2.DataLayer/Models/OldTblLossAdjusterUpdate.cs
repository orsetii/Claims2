using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldTblLossAdjusterUpdate
    {
        public int LauId { get; set; }
        public int LauClaimId { get; set; }
        public bool LauFirstContact { get; set; }
        public string? LauNextAction { get; set; }
        public DateTime? LauNextActionDate { get; set; }
        public string? LauContactMethod { get; set; }
        public DateTime? LauDeliveryDate { get; set; }
        public string? LauDetails { get; set; }
        public string LauStatusName { get; set; } = null!;
        public DateTime LauDate { get; set; }
        public bool LauSent { get; set; }
    }
}
