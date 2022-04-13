using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NcTblCBiOption
    {
        public int BiOptionId { get; set; }
        public int? BiDescriptionId { get; set; }
        public string? BiOption { get; set; }
        public int? BiScore { get; set; }
        public string? BiControl { get; set; }
    }
}
