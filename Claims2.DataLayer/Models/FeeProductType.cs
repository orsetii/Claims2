using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class FeeProductType
    {
        public int Id { get; set; }
        public int FeeId { get; set; }
        public int ProductTypeId { get; set; }

        public virtual Fee Fee { get; set; } = null!;
        public virtual Value1 ProductType { get; set; } = null!;
    }
}
