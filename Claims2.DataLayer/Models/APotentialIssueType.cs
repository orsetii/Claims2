using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class APotentialIssueType
    {
        public int PotentialIssueTypeId { get; set; }
        public string PotentialIssueTypeName { get; set; } = null!;
    }
}
