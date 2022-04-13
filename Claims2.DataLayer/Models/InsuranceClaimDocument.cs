using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class InsuranceClaimDocument
    {
        public InsuranceClaimDocument()
        {
            PrintQueueDocuments = new HashSet<PrintQueueDocument>();
        }

        public int DocumentId { get; set; }
        public int InsuranceClaimId { get; set; }
        public DateTime DateAdded { get; set; }
        public int? AddedBy { get; set; }
        public int? DocTypeId { get; set; }
        public string DocName { get; set; } = null!;
        public string? DocDescrip { get; set; }
        public string? OrigDocName { get; set; }
        public string? DocumentHtml { get; set; }
        public Guid Guid { get; set; }
        public int? DocumentTagId { get; set; }

        public virtual InsuranceClaim1 InsuranceClaim { get; set; } = null!;
        public virtual ICollection<PrintQueueDocument> PrintQueueDocuments { get; set; }
    }
}
