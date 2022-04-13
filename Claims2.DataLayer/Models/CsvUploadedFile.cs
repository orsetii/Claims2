using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CsvUploadedFile
    {
        public int Id { get; set; }
        public string Filename { get; set; } = null!;
        public byte[] FileBinary { get; set; } = null!;
        public string Csvtype { get; set; } = null!;
        public string MimeType { get; set; } = null!;
        public int BatchId { get; set; }
    }
}
