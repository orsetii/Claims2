using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class PrintQueueHistory
    {
        public PrintQueueHistory()
        {
            PrintQueueDocuments = new HashSet<PrintQueueDocument>();
        }

        public int Id { get; set; }
        public DateTime DateGenerated { get; set; }
        public int UserId { get; set; }
        public string DocumentName { get; set; } = null!;

        public virtual User2 User { get; set; } = null!;
        public virtual ICollection<PrintQueueDocument> PrintQueueDocuments { get; set; }
    }
}
