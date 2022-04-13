using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ADocTemplate
    {
        public int TemplateId { get; set; }
        public string TemplateName { get; set; } = null!;
        public int TemplateRecipient { get; set; }
        public bool TemplateLetterhead { get; set; }
        public bool TemplateAddress { get; set; }
        public int TemplateStructure { get; set; }
        public string TemplateText { get; set; } = null!;
        public int? TemplateEventId { get; set; }
    }
}
