using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Bak2304Family
    {
        public int FamilyId { get; set; }
        public int? CategoryId { get; set; }
        public string FamilyName { get; set; } = null!;
        public int? PgId { get; set; }
        public int BrandWeighting { get; set; }
        public bool Superseded { get; set; }
        public bool ContainsAccessories { get; set; }
        public bool PreExisting { get; set; }
        public int? LinkedFamilyId { get; set; }
        public double DefaultInstallation { get; set; }
        public double DefaultDelivery { get; set; }
        public string? Cnetid { get; set; }
    }
}
