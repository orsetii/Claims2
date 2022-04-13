using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ProductCode
    {
        public int ProdId { get; set; }
        /// <summary>
        /// Item type (claims DB)
        /// </summary>
        public int ProdItemTypeId { get; set; }
        /// <summary>
        /// For Liverpool Victoria bordereau invoice
        /// </summary>
        public string? ProdLvCode { get; set; }
        /// <summary>
        /// Link different product groups to N/L accounts
        /// </summary>
        public int ProdSalesNlAccountId { get; set; }
        public int ProdPurchasesNlAccountId { get; set; }
    }
}
