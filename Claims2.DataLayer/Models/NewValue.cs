using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NewValue
    {
        public int Id { get; set; }
        public int ParameterId { get; set; }
        public string Name { get; set; } = null!;
        public int? ParentValueId { get; set; }
        public int? CauseTypeId { get; set; }
        public int? SubcauseTypeId { get; set; }
        public int? ItemTypeId { get; set; }
        public int? GfkfamilyId { get; set; }
        public string? ImageUrl { get; set; }
    }
}
