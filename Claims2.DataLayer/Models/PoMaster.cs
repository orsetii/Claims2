using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class PoMaster
    {
        public int PomId { get; set; }
        public int PomStatusCode { get; set; }
        public int? PomNumber { get; set; }
        public DateTime? PomOrderDate { get; set; }
        public int PomClaimId { get; set; }
        public int PomSupplierId { get; set; }
        public string PomType { get; set; } = null!;
        public string? PomInstructions { get; set; }
        public int? PomCancelledById { get; set; }
        public DateTime? PomEmailedDate { get; set; }
        public DateTime? PomFaxedDate { get; set; }
        public DateTime? PomSentDate { get; set; }
        public int? PomConfirmedBy { get; set; }
        public DateTime? PomConfirmedOn { get; set; }
        public int? PomCreatedBy { get; set; }
        public DateTime? PomCreatedOn { get; set; }
        public DateTime? PomEmailedAgainDate { get; set; }
        public string? PomConfirmation { get; set; }
        public int? PomCancelsPoNumber { get; set; }
        public int? PomNewStatusCode { get; set; }
        public DateTime? PomEstimatedDelDate { get; set; }
        public DateTime? PomConfirmedDelDate { get; set; }
        public string? PomBriefDescription { get; set; }
        public int PomPhFollowUpStatus { get; set; }
    }
}
