using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class DocumentTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int RecipientId { get; set; }
        public bool ShowLetterhead { get; set; }
        public bool ShowAddress { get; set; }
        public int StructureId { get; set; }
        public string Text { get; set; } = null!;
        public int BottomMargin { get; set; }
    }
}
