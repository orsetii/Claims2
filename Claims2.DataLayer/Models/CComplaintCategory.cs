using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CComplaintCategory
    {
        public int ComplaintCategoryId { get; set; }
        public string ComplaintCategoryName { get; set; } = null!;
        public bool Deleted { get; set; }
    }
}
