﻿using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldSOutcome
    {
        public int SOutcomeId { get; set; }
        public string? SOutcome { get; set; }
        public int? SSort { get; set; }
        public int? NewId { get; set; }
    }
}
