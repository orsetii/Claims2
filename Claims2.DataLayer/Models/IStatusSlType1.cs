using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class IStatusSlType1
    {
        public IStatusSlType1()
        {
            IStatusSlNextAction1s = new HashSet<IStatusSlNextAction1>();
            IStatusSlPath1IStatusPathEndNavigations = new HashSet<IStatusSlPath1>();
            IStatusSlPath1IStatusPathStartNavigations = new HashSet<IStatusSlPath1>();
        }

        public int ISSlTypeId { get; set; }
        public string ISSlTypeName { get; set; } = null!;
        public int ISSlTypeTl { get; set; }
        public int ISSlTypeTime { get; set; }
        public bool ISSlTypeCloses { get; set; }
        public bool ISSlMiClosed { get; set; }
        public int? MiCat { get; set; }

        public virtual ICollection<IStatusSlNextAction1> IStatusSlNextAction1s { get; set; }
        public virtual ICollection<IStatusSlPath1> IStatusSlPath1IStatusPathEndNavigations { get; set; }
        public virtual ICollection<IStatusSlPath1> IStatusSlPath1IStatusPathStartNavigations { get; set; }
    }
}
