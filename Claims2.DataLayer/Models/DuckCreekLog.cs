using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class DuckCreekLog
    {
        public int Id { get; set; }
        public bool IsError { get; set; }
        public string? Message { get; set; }
        public string? Instruction { get; set; }
        public string? Claim { get; set; }
        public Guid? AccountGuid { get; set; }
        public DateTime? DateReceived { get; set; }
        public bool WasClaimCreated { get; set; }
        public bool WasItemCreated { get; set; }
        public Guid? ValidationClaimGuid { get; set; }
        public string? DcclaimId { get; set; }
        public string? DcfileNoteId { get; set; }
        public int? ItemId { get; set; }
        public int? ClaimId { get; set; }
        public bool WasFileNoteSentBack { get; set; }
    }
}
