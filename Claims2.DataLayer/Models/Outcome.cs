using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Outcome
    {
        public int Id { get; set; }
        public string Outcome1 { get; set; } = null!;
        public int? MioutcomeId { get; set; }
        public string? LloydsOutcome { get; set; }
        public string? AdmiralOutcome { get; set; }
        public string? CoveaOutcome { get; set; }
        public string? AllianzOutcome { get; set; }
    }
}
