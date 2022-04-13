using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NlDefault
    {
        public int NldId { get; set; }
        /// <summary>
        /// see stDocumentation
        /// </summary>
        public string NldCode { get; set; } = null!;
        /// <summary>
        /// NL Account ID
        /// </summary>
        public int NldNlaId { get; set; }
        public string? NldComment { get; set; }
    }
}
