using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Parameter
    {
        public Parameter()
        {
            Values = new HashSet<Value>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? ParentParameterId { get; set; }
        public bool LookUpParameter { get; set; }

        public virtual ICollection<Value> Values { get; set; }
    }
}
