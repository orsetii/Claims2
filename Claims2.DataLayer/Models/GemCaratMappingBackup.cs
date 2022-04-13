using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class GemCaratMappingBackup
    {
        public int Id { get; set; }
        public int GemTypeId { get; set; }
        public int? GemCutId { get; set; }
        public int GemDimensionsId { get; set; }
        public int? GemCaratId { get; set; }
    }
}
