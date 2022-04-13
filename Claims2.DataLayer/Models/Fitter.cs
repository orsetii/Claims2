using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Fitter
    {
        public Fitter()
        {
            FitterPricings = new HashSet<FitterPricing>();
        }

        public int FlFitterId { get; set; }
        public string Name { get; set; } = null!;
        public string ContactName { get; set; } = null!;
        public string ContactTelephone1 { get; set; } = null!;
        public string? ContactTelephone2 { get; set; }
        public string? Address { get; set; }
        public string? ContactEmail { get; set; }
        public int? SupplierId { get; set; }

        public virtual Supplier1? Supplier { get; set; }
        public virtual ICollection<FitterPricing> FitterPricings { get; set; }
    }
}
