using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Category1
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public bool PreExisting { get; set; }
        public int? GfkCategoryId { get; set; }
        public int GfksectorId { get; set; }
        public string? Cnetid { get; set; }
    }
}
