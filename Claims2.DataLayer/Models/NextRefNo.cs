using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NextRefNo
    {
        public int NrnId { get; set; }
        /// <summary>
        /// Next invoice number
        /// </summary>
        public int NrnInvoice1 { get; set; }
        /// <summary>
        /// (If using secondary sequence)
        /// </summary>
        public int? NrnInvoice2 { get; set; }
        /// <summary>
        /// Next credit note number
        /// </summary>
        public int? NrnPoNumber1 { get; set; }
        /// <summary>
        /// (If using secondary sequence)
        /// </summary>
        public int? NrnPoNumber2 { get; set; }
        public int NrnSlAllocRef { get; set; }
        public int NrnPlAllocRef { get; set; }
        /// <summary>
        /// Prefix letter(s) for sequence 1
        /// </summary>
        public string? NrnInv1Prefix { get; set; }
        public string? NrnInv2Prefix { get; set; }
        public string? NrnCn1Prefix { get; set; }
        public string? NrnCn2Prefix { get; set; }
        public bool NrnPoLocked { get; set; }
        public int NrnJeRef { get; set; }
        public bool NrnSiLocked { get; set; }
        public int NrnLgBordereau { get; set; }
        public int NrnMiSalesInv { get; set; }
    }
}
