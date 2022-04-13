using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ServiceProductType
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int ProductTypeId { get; set; }

        public virtual Value1 ProductType { get; set; } = null!;
        public virtual Service Service { get; set; } = null!;
    }
}
