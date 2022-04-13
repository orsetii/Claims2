using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ComplaintDatum
    {
        public int? Complaintid { get; set; }
        public string? Complaintcategoryname { get; set; }
        public DateTime? Daterecived { get; set; }
        public DateTime? Datecreated { get; set; }
        public int? Claimid { get; set; }
        public string? Username { get; set; }
        public string? Insuredname { get; set; }
        public string? Insuredfirstname { get; set; }
        public string? Insuredlastname { get; set; }
        public string? Hometelephone { get; set; }
        public string? Email { get; set; }
        public string? Insuredaddress1 { get; set; }
        public string? Insuredaddress2 { get; set; }
        public string? Insuredaddress3 { get; set; }
        public string? Insuredpostcode { get; set; }
        public string? Relatedproduct { get; set; }
        public string? Lossadjuster { get; set; }
        public string? Insurersref { get; set; }
        public string? Insuredcompany { get; set; }
        public string? Resolution { get; set; }
        public string? ReasonForComplaint { get; set; }
        public DateTime? DateResolved { get; set; }
        public string? JustifiedUnjustified { get; set; }
        public string? Paymentsout { get; set; }
        public string? ReasonForPaymentOut { get; set; }
        public string? CompensationType { get; set; }
        public string? ComplaintFormFilledIn { get; set; }
    }
}
