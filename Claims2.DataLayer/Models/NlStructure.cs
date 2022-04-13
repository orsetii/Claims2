using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NlStructure
    {
        public int NlsId { get; set; }
        /// <summary>
        /// eg. Turnover, Cost of Sales
        /// </summary>
        public string? NlsName { get; set; }
        /// <summary>
        /// P&amp;L or Balance Sheet
        /// </summary>
        public string NlsPb { get; set; } = null!;
        /// <summary>
        /// Order to present groups
        /// </summary>
        public int NlsOrder { get; set; }
        /// <summary>
        /// Expected value (Debit or Credit) - if not, show as -ve
        /// </summary>
        public string NlsDcExpected { get; set; } = null!;
        /// <summary>
        /// If negative (see above), move to this group
        /// </summary>
        public int? NlsDcAltGroup { get; set; }
        public int? NlsCreatedBy { get; set; }
        public DateTime? NlsCreatedOn { get; set; }
        public int? NlsEditedBy { get; set; }
        public DateTime? NlsEditedOn { get; set; }
    }
}
