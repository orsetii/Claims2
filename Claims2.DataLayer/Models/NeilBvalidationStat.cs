using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NeilBvalidationStat
    {
        public int Id { get; set; }
        public string Use { get; set; } = null!;
        public string User { get; set; } = null!;
        public string Insurer { get; set; } = null!;
        public DateTime When { get; set; }
        public string? Lareference { get; set; }
        public string? PostCode { get; set; }
        public string? InsuredLastName { get; set; }
        public string? PolicyNumber { get; set; }
        public string? SearchString { get; set; }
        public int? SbsclaimId { get; set; }
    }
}
