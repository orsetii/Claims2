using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ItemStatus
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Order { get; set; }
        public string Stage { get; set; } = null!;
        public int? NewActionId { get; set; }
    }
}
