using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ReportSetting
    {
        public int Id { get; set; }
        public int ReportId { get; set; }
        public int StartActionId { get; set; }
        public int EndActionId { get; set; }
    }
}
