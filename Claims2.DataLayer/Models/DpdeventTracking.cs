using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class DpdeventTracking
    {
        public int Id { get; set; }
        public string? ParcelNumber { get; set; }
        public string? LogType { get; set; }
        public string? EventDate { get; set; }
        public string? EventTime { get; set; }
        public string? EventLocation { get; set; }
        public string? EventDescription { get; set; }
        public string? ConsignmentNumber { get; set; }
        public string? ConsignmentLine { get; set; }
        public string? AccountNumber { get; set; }
        public string? SendersRef { get; set; }
        public string? ChecklistQuestionCode { get; set; }
        public string? ChecklistQuestionDescription { get; set; }
        public string? CheckListResponse { get; set; }
        public int? Insuranceclaimid { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
