using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class DocumentLink
    {
        public int DlId { get; set; }
        /// <summary>
        /// Link to prime entry posting
        /// </summary>
        public int DlPemId { get; set; }
        /// <summary>
        /// Path and file name of doc/image/etc.
        /// </summary>
        public string? DlDocumentUrl { get; set; }
    }
}
