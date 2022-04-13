using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BrandBanding
    {
        public int BandingId { get; set; }
        public int AccountId { get; set; }
        public int FamilyId { get; set; }
        public int BrandId { get; set; }
        public int Band { get; set; }
    }
}
