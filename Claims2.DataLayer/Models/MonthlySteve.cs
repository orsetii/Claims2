using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class MonthlySteve
    {
        public int MiId { get; set; }
        public int? Insuranceclaimid { get; set; }
        public string? Consignment { get; set; }
        public bool Closed { get; set; }
        public int? CloseStatus { get; set; }
        public int? MiCat { get; set; }
        public DateTime? OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public int? OpenMonth { get; set; }
        public int? OpenYear { get; set; }
        public int? CloseMonth { get; set; }
        public int? CloseYear { get; set; }
        public string? AccountRef { get; set; }
        public int? Lossadjusterid { get; set; }
        public bool Forced { get; set; }
        public string? Openx { get; set; }
        public string? Closex { get; set; }
        public int? ItemTypeId { get; set; }
        public string? ItemType { get; set; }
        public int? CauseTypeId { get; set; }
        public string? CauseType { get; set; }
        public int? SubCauseTypeId { get; set; }
        public string? SubCauseType { get; set; }
        public int? MiCauseId { get; set; }
        public string? MiCause { get; set; }
        public int? OldMiCat { get; set; }
        public int? OldCloseStatus { get; set; }
        public bool Donemi { get; set; }
        public string? Olddate { get; set; }
        public int? CurrentStatus { get; set; }
        public int? MiVer { get; set; }
        public int? Claimtime { get; set; }
        public int? CvSample { get; set; }
        public decimal? CvValue { get; set; }
        public decimal? CvCost { get; set; }
        public decimal? CvInspCost { get; set; }
        public decimal? CvSaving { get; set; }
        public decimal? GrossReplace { get; set; }
        public decimal? GrossRepair { get; set; }
        public int? Hasbi { get; set; }
        public int? BiScore { get; set; }
    }
}
