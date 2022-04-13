using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ActionProfileDetail
    {
        public int Id { get; set; }
        public int ParameterId { get; set; }
        public int? ValueId { get; set; }
        public string? Value { get; set; }
        public string? Operation { get; set; }
        public int? ProfileId { get; set; }

        public virtual Parameter1 Parameter { get; set; } = null!;
        public virtual ActionProfile? Profile { get; set; }
        public virtual Value1? ValueNavigation { get; set; }
    }
}
