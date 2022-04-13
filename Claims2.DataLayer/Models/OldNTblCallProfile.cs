using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldNTblCallProfile
    {
        public int CallProfId { get; set; }
        public int? Caller { get; set; }
        public int? CallType { get; set; }
        public int? Reason { get; set; }
        /// <summary>
        /// The event thats associated with making a call on this profile
        /// </summary>
        public int EventId { get; set; }
        /// <summary>
        /// Should this call profile be used
        /// </summary>
        public bool? Open { get; set; }
    }
}
