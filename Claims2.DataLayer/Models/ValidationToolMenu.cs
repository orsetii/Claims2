using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ValidationToolMenu
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int ValueId { get; set; }
        public int ParentValueId { get; set; }
        public bool IsProduct { get; set; }
        public string? ImageUrl { get; set; }
    }
}
