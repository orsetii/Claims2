using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class EsureSurveyResult
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
        public string? PostCode { get; set; }
        public string? Question1 { get; set; }
        public string? Question2 { get; set; }
        public string? Question3 { get; set; }
        public string? CommentsBox { get; set; }
    }
}
