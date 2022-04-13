using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Fee
    {
        public Fee()
        {
            FeeProductTypes = new HashSet<FeeProductType>();
            SupplierFees = new HashSet<SupplierFee>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Code { get; set; }
        public int? OldProductId { get; set; }
        public bool VariableFee { get; set; }
        public string? Source { get; set; }
        public decimal Cost { get; set; }
        public int TypeId { get; set; }
        public bool? FixedClaimFee { get; set; }
        public bool Deleted { get; set; }

        public virtual Product1? OldProduct { get; set; }
        public virtual FeeType Type { get; set; } = null!;
        public virtual ICollection<FeeProductType> FeeProductTypes { get; set; }
        public virtual ICollection<SupplierFee> SupplierFees { get; set; }
    }
}
