using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SInsp1
    {
        public int SInspectionId { get; set; }
        public int? SInspItem { get; set; }
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
        public int? SInspectionItem { get; set; }
        public string? SFContact { get; set; }
        public string? SFTitle { get; set; }
        public string? SFFirstname { get; set; }
        public string? SFLastname { get; set; }
        public string? SFAddress1 { get; set; }
        public string? SFAddress2 { get; set; }
        public string? SFAddress3 { get; set; }
        public string? SFAddress4 { get; set; }
        public string? SFPostcode { get; set; }
        public string? SFPhone { get; set; }
        public int? STlId { get; set; }
        public int? SSlId { get; set; }
        public string? SSpecInstr { get; set; }
        public int? SStatus { get; set; }
        public DateTime? SLastUpdated { get; set; }
        public string? SStatusComments { get; set; }
        public int? SDelAccId { get; set; }
        public string? SDelRef { get; set; }
        public DateTime? SDelDate { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public int? SOutcome { get; set; }
        public string? SPrinted { get; set; }
        public string? SrPrinted { get; set; }
        public int? SDelBoxId { get; set; }
    }
}
