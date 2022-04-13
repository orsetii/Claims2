using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NextAction
    {
        public int Id { get; set; }
        public int PrevActionId { get; set; }
        public int NextActionId { get; set; }

        public virtual Action NextActionNavigation { get; set; } = null!;
        public virtual Action PrevAction { get; set; } = null!;
    }
}
