using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class DpdParcelEventCode
    {
        public int Id { get; set; }
        public string LogType { get; set; } = null!;
        public string LogName { get; set; } = null!;
        public string LogDescription { get; set; } = null!;
        public bool EmailTask { get; set; }
        public bool ShowToHandler { get; set; }
    }
}
