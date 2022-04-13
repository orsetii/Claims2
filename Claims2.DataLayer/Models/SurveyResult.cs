using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SurveyResult
    {
        public int Id { get; set; }
        public string? Group { get; set; }
        public string? Number { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Custom1 { get; set; }
        public string? Custom2 { get; set; }
        public string? Custom3 { get; set; }
        public string? Datetime { get; set; }
        public string? Complete { get; set; }
        public string? Device { get; set; }
        public string? SpeedOfResponse { get; set; }
        public string? Informed { get; set; }
        public string? Quality { get; set; }
        public string? Politeness { get; set; }
        public string? Consideration { get; set; }
        public string? CommitmentAndProfessionalism { get; set; }
        public string? AdditionalComments { get; set; }
        public string? PostCode { get; set; }
        public string? Rating { get; set; }
        public string? OverallExperience { get; set; }
        public string? PersonalInvolvement { get; set; }
    }
}
