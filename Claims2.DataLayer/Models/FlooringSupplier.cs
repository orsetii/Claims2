using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class FlooringSupplier
    {
        public FlooringSupplier()
        {
            Floorings = new HashSet<Flooring>();
        }

        public int FlSupplierId { get; set; }
        public string Name { get; set; } = null!;
        public int? SupplierId { get; set; }
        public bool? CanFreetypeProducts { get; set; }
        public bool? VoucherOnlySupplier { get; set; }

        public virtual Supplier1? Supplier { get; set; }
        public virtual ICollection<Flooring> Floorings { get; set; }
    }
}
