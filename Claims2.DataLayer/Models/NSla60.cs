﻿using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NSla60
    {
        public int? Claimid { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public int? MsgType { get; set; }
    }
}