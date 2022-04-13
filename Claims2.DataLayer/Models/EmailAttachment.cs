using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class EmailAttachment
    {
        public int Id { get; set; }
        public byte[] File { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public string MimeType { get; set; } = null!;
        public string EmailId { get; set; } = null!;
        public int Eid { get; set; }
    }
}
