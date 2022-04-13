using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SViewInspection
    {
        public int SInspItem { get; set; }
        public int? SClaimId { get; set; }
        public int? SClaimItemId { get; set; }
        public string? SContact { get; set; }
        public string? STitle { get; set; }
        public string? SFirstname { get; set; }
        public string? SLastname { get; set; }
        public string? SAddress1 { get; set; }
        public string? SAddress2 { get; set; }
        public string? SAddress3 { get; set; }
        public string? SAddress4 { get; set; }
        public string? SPostcode { get; set; }
        public string? SPhonehome { get; set; }
        public string? SPhonework { get; set; }
        public string? SPhonemobile { get; set; }
        public int? SProductType { get; set; }
        public string? SItemDesc { get; set; }
        public int? SInspType { get; set; }
        public int? SInspCompany { get; set; }
        public int? SInsCompany { get; set; }
        public string? SCreatedBy { get; set; }
        public int? SStatus { get; set; }
        public DateTime? SCreatedOn { get; set; }
        public string? Description { get; set; }
        public string? SInsDesc { get; set; }
        public string SInspDesc { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string? SSpecInstr { get; set; }
        public string? SStatusDesc { get; set; }
        public int? SDelAccId { get; set; }
        public string? SDelRef { get; set; }
        public string? SInspCoDesc { get; set; }
        public int SInspectionId { get; set; }
        public bool? SQuarantine { get; set; }
        public int? SQuarantineTime { get; set; }
        public DateTime? SQuarantineFrom { get; set; }
        public DateTime? SQuarantineTo { get; set; }
        public bool? SBackup { get; set; }
        public DateTime? SBackupRequestOn { get; set; }
        public string? SBackupDetails { get; set; }
        public DateTime? SBackupDate { get; set; }
        public string? SBackupComments { get; set; }
        public string? SMake { get; set; }
        public string? SModel { get; set; }
        public string? SCondition { get; set; }
        public string? SEngineer { get; set; }
        public string? SDamageDetails { get; set; }
        public int? SFaultType { get; set; }
        public string? SDName { get; set; }
        public string? SDAddress1 { get; set; }
        public string? SDAddress2 { get; set; }
        public string? SDAddress3 { get; set; }
        public string? SDAddress4 { get; set; }
        public string? SDPostcode { get; set; }
    }
}
