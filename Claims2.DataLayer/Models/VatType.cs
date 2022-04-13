using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class VatType
    {
        public int VtId { get; set; }
        /// <summary>
        /// V!, V2, V11, V12, etc
        /// </summary>
        public string? VtCode { get; set; }
        /// <summary>
        /// For VAT return reporting (net outputs, inputs, EU sales, etc.)
        /// </summary>
        public string? VtName { get; set; }
        public int? VtCreatedBy { get; set; }
        public DateTime? VtCreatedOn { get; set; }
        public int? VtEditedBy { get; set; }
        public DateTime? VtEditedOn { get; set; }
    }
}
