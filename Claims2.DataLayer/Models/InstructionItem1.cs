using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class InstructionItem1
    {
        public int InstructionItemId { get; set; }
        public int? InstructionId { get; set; }
        public int? ItemTypeId { get; set; }
        public string? ItemDescription { get; set; }
        public double? ItemValue { get; set; }
    }
}
