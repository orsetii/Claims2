using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ExtendedFamily
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int FamilyId { get; set; }

        public virtual Family Family { get; set; } = null!;
    }
}
