using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SInspectionDatum
    {
        public int SInspectionId { get; set; }
        public int? SInspItem { get; set; }
        public bool? SQuarantine { get; set; }
        public DateTime? SQuarantineFrom { get; set; }
        public DateTime? SQuarantineTo { get; set; }
        public int? SQuarantineTime { get; set; }
        public bool? SBackup { get; set; }
        public DateTime? SBackupRequestOn { get; set; }
        public string? SBackupDetails { get; set; }
        public DateTime? SBackupDate { get; set; }
        public string? SBackupComments { get; set; }
        public string? SCondition { get; set; }
        public string? SModel { get; set; }
        public string? SMake { get; set; }
        public string? SEngineer { get; set; }
        public string? SDamageDetails { get; set; }
        public int? SFaultType { get; set; }
        public int? SInspectionItem { get; set; }
        public string? SFContact { get; set; }
        public string? SFAddress1 { get; set; }
        public string? SFAddress2 { get; set; }
        public string? SFAddress3 { get; set; }
        public string? SFAddress4 { get; set; }
        public string? SFPhone { get; set; }
        public string? SFPostcode { get; set; }
        public int? SProductType { get; set; }
        public string? SItemDesc { get; set; }
        public int? SInspType { get; set; }
        public int? SInspCompany { get; set; }
        public string? SInspCoDesc { get; set; }
        public string? Description { get; set; }
        public string ProductCode { get; set; } = null!;
        public string SInspDesc { get; set; } = null!;
        public string? SSpecInstr { get; set; }
        public int? SStatus { get; set; }
        public string? SStatusDesc { get; set; }
        public int? SDelAccId { get; set; }
        public string? SDelRef { get; set; }
        public string? SDelAccDesc { get; set; }
        public int? SClaimId { get; set; }
        public string? SStatusComments { get; set; }
        public DateTime? SLastUpdated { get; set; }
        public int? SInsCompany { get; set; }
        public string? SInsDesc { get; set; }
    }
}
