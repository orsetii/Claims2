using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SelectedInstruction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int EmailId { get; set; }
        public DateTime SelectionDate { get; set; }
    }
}
