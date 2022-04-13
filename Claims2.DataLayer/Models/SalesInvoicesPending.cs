using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SalesInvoicesPending
    {
        public int SipId { get; set; }
        public int SipClaimId { get; set; }
        /// <summary>
        /// Ready to invoice master file items
        /// </summary>
        public bool SipClaimMaster { get; set; }
        /// <summary>
        /// Ready to invoice detail items
        /// </summary>
        public bool SipClaimDetail { get; set; }
    }
}
