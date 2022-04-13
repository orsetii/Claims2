using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SConfirmInsp
    {
        public int SClaimItemId { get; set; }
        public int? SClaimorderid { get; set; }
        public int? SInsuranceclaimid { get; set; }
        public int InsuranceCompanyId { get; set; }
        public string? Inscompany { get; set; }
        public int? SProductid { get; set; }
        public int? SItemtypeid { get; set; }
        public string? STlDesc { get; set; }
        public string ProductCode { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int? SSupplierid { get; set; }
        public int SInspCo { get; set; }
        public string? SInspCoDesc { get; set; }
        public string? InsuredFirstName { get; set; }
        public string? InsuredLastName { get; set; }
        public string? InsuredName { get; set; }
        public string? InsuredTitle { get; set; }
        public string? InsuredAddress1 { get; set; }
        public string? InsuredAddress2 { get; set; }
        public string? InsuredAddress3 { get; set; }
        public string? InsuredAddress4 { get; set; }
        public string? InsuredPostCode { get; set; }
        public string? DeliveryAddress1 { get; set; }
        public string? DeliveryAddress2 { get; set; }
        public string? DeliveryAddress3 { get; set; }
        public string? DeliveryAddress4 { get; set; }
        public string? DeliveryPostCode { get; set; }
        public string? Telephone { get; set; }
        public string? HomeTelephone { get; set; }
        public string? WorkTelephone { get; set; }
        public string? Mobile { get; set; }
        public bool? SQuarantine { get; set; }
        public int? SQuarantineTime { get; set; }
        public DateTime? SQuarantineTo { get; set; }
        public DateTime? SQuarantineFrom { get; set; }
        public bool? SBackup { get; set; }
        public DateTime? SBackupRequestOn { get; set; }
        public string? SBackupDetails { get; set; }
        public DateTime? SBackupDate { get; set; }
        public string? SBackupComments { get; set; }
        public string? SFContact { get; set; }
        public string? SFTitle { get; set; }
        public string? SFFirstname { get; set; }
        public string? SFAddress2 { get; set; }
        public string? SFAddress1 { get; set; }
        public string? SFLastname { get; set; }
        public string? SFAddress3 { get; set; }
        public string? SFAddress4 { get; set; }
        public string? SFPostcode { get; set; }
        public string? SFPhone { get; set; }
        public string? SSpecInstr { get; set; }
        public int? SStatus { get; set; }
        public string? SStatusDesc { get; set; }
        public DateTime? SLastUpdated { get; set; }
        public string? SStatusComments { get; set; }
        public int? SDelAccId { get; set; }
        public string? SDelRef { get; set; }
        public int? STlId { get; set; }
        public int? SSlId { get; set; }
        public string? SMake { get; set; }
        public string? SModel { get; set; }
        public string? SCondition { get; set; }
        public string? SEngineer { get; set; }
        public string? SDamageDetails { get; set; }
        public int? SFaultType { get; set; }
        public int? SInspectionItem { get; set; }
        public DateTime? SDelDate { get; set; }
        public string? SCreatedby { get; set; }
        public string? SPrinted { get; set; }
        public string? SrPrinted { get; set; }
        public DateTime? SCreatedon { get; set; }
        public string? SOutcome { get; set; }
        public int? OriginalClaimItemId { get; set; }
    }
}
