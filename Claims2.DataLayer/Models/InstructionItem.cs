using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class InstructionItem
    {
        public int ItemId { get; set; }
        public int UnconfirmedInstructionId { get; set; }
        public int? InstructionId { get; set; }
        public string? Description { get; set; }
        public double? Value { get; set; }
        public string? ItemPropertyIds { get; set; }
        public int? OutcomeId { get; set; }
        public bool Confirmed { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateConfirmed { get; set; }
        public string? Source { get; set; }
    }
}
