using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class DocImportLossAdjuster
    {
        public int Id { get; set; }
        public int Laid { get; set; }
        public string Laref { get; set; } = null!;
        public string? Laname { get; set; }
        public string? Address { get; set; }
        public string? Key { get; set; }
        public int SetupId { get; set; }
    }
}
