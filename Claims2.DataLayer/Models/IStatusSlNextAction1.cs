using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class IStatusSlNextAction1
    {
        public int IStatusSlNaId { get; set; }
        public int? IStatusSlLevel { get; set; }
        public string? IStatusSlNextaction { get; set; }
        public string? IStatusSlInstructiontype { get; set; }
        public int? IStatusSlAssociatedPath { get; set; }

        public virtual IStatusSlPath1? IStatusSlAssociatedPathNavigation { get; set; }
        public virtual IStatusSlType1? IStatusSlLevelNavigation { get; set; }
    }
}
