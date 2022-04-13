using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class AutoPriceNote
    {
        public int ApnId { get; set; }
        /// <summary>
        /// If null, then this relates to carriage (ref sim_id)
        /// </summary>
        public int? ApnSidId { get; set; }
        public int ApnSimId { get; set; }
        public string? ApnChNotes { get; set; }
        public string? ApnAccNotes { get; set; }
    }
}
