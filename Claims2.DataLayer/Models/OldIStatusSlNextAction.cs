using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldIStatusSlNextAction
    {
        public int IStatusSlNaId { get; set; }
        public int? IStatusSlLevel { get; set; }
        public string? IStatusSlNextaction { get; set; }
        public string? IStatusSlInstructiontype { get; set; }
        public int? IStatusSlAssociatedPath { get; set; }

        public virtual OldIStatusSlPath? IStatusSlAssociatedPathNavigation { get; set; }
        public virtual OldIStatusSlType? IStatusSlLevelNavigation { get; set; }
    }
}
