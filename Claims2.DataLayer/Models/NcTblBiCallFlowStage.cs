using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NcTblBiCallFlowStage
    {
        public int CallFlowRelId { get; set; }
        public int? CallFlowStageId { get; set; }
        public string? CallFlowStage { get; set; }
        public string? DisplayName { get; set; }
        public int? BiTypeId { get; set; }
        public int? CallFlowStageOrder { get; set; }
        public string? CallFlowText { get; set; }
        public int CallFlowTypeId { get; set; }
        public int? ScenarioId { get; set; }
        public bool DynamicFnol { get; set; }
    }
}
