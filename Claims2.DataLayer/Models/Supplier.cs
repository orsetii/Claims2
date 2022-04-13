using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            DiamondImports = new HashSet<DiamondImport>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double DefaultInstallation { get; set; }
        public double DefaultDelivery { get; set; }
        public int? OldSupplierId { get; set; }
        public bool VoucherCapable { get; set; }
        public bool EvoucherCapable { get; set; }
        public bool? ReplacementCapable { get; set; }
        public bool Agrade { get; set; }

        public virtual ICollection<DiamondImport> DiamondImports { get; set; }
    }
}
