using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class PrintQueueDocument
    {
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public bool Printed { get; set; }
        public DateTime DateAdded { get; set; }
        public int AddedBy { get; set; }
        public bool Removed { get; set; }
        public DateTime? DateRemoved { get; set; }
        public int? RemovedBy { get; set; }
        public int? PrintQueueHistoryId { get; set; }

        public virtual User2 AddedByNavigation { get; set; } = null!;
        public virtual InsuranceClaimDocument Document { get; set; } = null!;
        public virtual PrintQueueHistory? PrintQueueHistory { get; set; }
        public virtual User2? RemovedByNavigation { get; set; }
    }
}
