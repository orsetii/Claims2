﻿using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldCComplaintStatus
    {
        public int ComplaintStatusId { get; set; }
        public string ComplaintStatusText { get; set; } = null!;
    }
}
