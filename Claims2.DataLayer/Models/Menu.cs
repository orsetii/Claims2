using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Menu
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int ParentId { get; set; }
        public int? PathId { get; set; }
        public string? Url { get; set; }
        public int DisplayOrder { get; set; }
        public string? FeatherIcon { get; set; }
    }
}
