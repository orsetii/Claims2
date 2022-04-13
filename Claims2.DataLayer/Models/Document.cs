using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Document
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Timestamp { get; set; }
        public byte[] Document1 { get; set; } = null!;
        public string MimeType { get; set; } = null!;
        public string FileName { get; set; } = null!;

        public virtual User2 User { get; set; } = null!;
    }
}
