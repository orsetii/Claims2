using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class PrimeEntryMaster
    {
        public int PemId { get; set; }
        public DateTime PemDate { get; set; }
        public int PemAccountingPeriod { get; set; }
        public int PemTransPeriod { get; set; }
        public int? PemExternalRef { get; set; }
        public string PemPostingType { get; set; } = null!;
        public int? PemBankType { get; set; }
        public int? PemCustSupp { get; set; }
        public int? PemInsCoId { get; set; }
        public string? PemTransRef { get; set; }
        public string? PemName { get; set; }
        public string? PemDescription { get; set; }
        public int? PemClaimId { get; set; }
        public decimal PemGross { get; set; }
        public decimal PemVat { get; set; }
        public decimal PemNet { get; set; }
        public int? PemDeCode { get; set; }
        public int? PemVatType { get; set; }
        public int? PemCreatedBy { get; set; }
        public DateTime? PemCreatedOn { get; set; }
        public int? PemEditedBy { get; set; }
        public DateTime? PemEditedOn { get; set; }
    }
}
