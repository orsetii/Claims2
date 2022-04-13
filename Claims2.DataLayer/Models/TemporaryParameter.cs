using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class TemporaryParameter
    {
        public TemporaryParameter()
        {
            TemporaryValues = new HashSet<TemporaryValue>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? ParentParameterId { get; set; }
        public bool Required { get; set; }
        public bool LookUpParameter { get; set; }
        public bool ClaimLevel { get; set; }

        public virtual ICollection<TemporaryValue> TemporaryValues { get; set; }
    }
}
