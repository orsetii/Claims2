using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldTblInsuranceClaimDocument
    {
        public int DocumentId { get; set; }
        public int InsuranceClaimId { get; set; }
        public DateTime DateAdded { get; set; }
        public int? AddedBy { get; set; }
        public int? DocTypeId { get; set; }
        public string DocName { get; set; } = null!;
        public string? DocDescrip { get; set; }
    }
}
