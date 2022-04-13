using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class TransactionLog
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string Sent { get; set; } = null!;
        public string Recived { get; set; } = null!;
    }
}
