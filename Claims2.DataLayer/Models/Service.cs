using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Service
    {
        public Service()
        {
            FittingCosts = new HashSet<FittingCost>();
            ServiceAttributeValues = new HashSet<ServiceAttributeValue>();
            ServiceDays = new HashSet<ServiceDay>();
            ServiceProductTypes = new HashSet<ServiceProductType>();
            SupplierServices = new HashSet<SupplierService>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public int? OldProductId { get; set; }
        public bool Unlisted { get; set; }
        public bool AddDpd { get; set; }
        public int TypeId { get; set; }
        public bool Deleted { get; set; }

        public virtual Product1? OldProduct { get; set; }
        public virtual ServiceType Type { get; set; } = null!;
        public virtual ICollection<FittingCost> FittingCosts { get; set; }
        public virtual ICollection<ServiceAttributeValue> ServiceAttributeValues { get; set; }
        public virtual ICollection<ServiceDay> ServiceDays { get; set; }
        public virtual ICollection<ServiceProductType> ServiceProductTypes { get; set; }
        public virtual ICollection<SupplierService> SupplierServices { get; set; }
    }
}
