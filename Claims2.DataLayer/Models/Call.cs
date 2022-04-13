using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Call
    {
        public int CallId { get; set; }
        public int? CallProfId { get; set; }
        public string? CallNotes { get; set; }
        public int? CallBy { get; set; }
        public DateTime? CallOn { get; set; }
        public int? InsuranceClaimId { get; set; }
        public int? WarrantyClaimId { get; set; }
        public bool? CallAnswered { get; set; }
        public bool? ReturnCallRequired { get; set; }
        public int? CallTypeId { get; set; }
        public int? CallTo { get; set; }
        public bool? Dpasuccessful { get; set; }
        public string? CallToOtherDetails { get; set; }

        public virtual CallProfile? CallProf { get; set; }
    }
}
