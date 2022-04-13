using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class FeeCategoryProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int FeeCategoryId { get; set; }
    }
}
