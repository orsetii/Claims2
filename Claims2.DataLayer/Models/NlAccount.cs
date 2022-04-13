using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NlAccount
    {
        public int NlaId { get; set; }
        /// <summary>
        /// NL Code (eg Sage code)
        /// </summary>
        public int NlaCode { get; set; }
        public string NlaName { get; set; } = null!;
        /// <summary>
        /// Link to NL structure table
        /// </summary>
        public int NlaNlsId { get; set; }
        /// <summary>
        /// =1 if this is a &quot;bank type&quot; account
        /// </summary>
        public bool NlaBank { get; set; }
        /// <summary>
        /// To disable postings to redundant accounts
        /// </summary>
        public bool NlaActive { get; set; }
        public int? NlaCreatedBy { get; set; }
        public DateTime? NlaCreatedOn { get; set; }
        public int? NlaEditedBy { get; set; }
        public DateTime? NlaEditedOn { get; set; }
        public decimal NlaPriorYearBf { get; set; }
        public decimal NlaCurrentYearBf { get; set; }
    }
}
