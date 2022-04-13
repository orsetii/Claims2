using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Value
    {
        public int Id { get; set; }
        public int ParameterId { get; set; }
        public string Name { get; set; } = null!;

        public virtual Parameter Parameter { get; set; } = null!;
    }
}
