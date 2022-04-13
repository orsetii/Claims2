using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ProductReplacementCache
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ReplacementId { get; set; }
        public int Count { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
