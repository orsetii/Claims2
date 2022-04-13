using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ActionHistory1
    {
        public int Id { get; set; }
        public int? InspectionId { get; set; }
        public int ActionOrder { get; set; }
        public DateTime Date { get; set; }
    }
}
