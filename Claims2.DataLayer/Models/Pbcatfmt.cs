﻿using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Pbcatfmt
    {
        public string PbfName { get; set; } = null!;
        public string PbfFrmt { get; set; } = null!;
        public short PbfType { get; set; }
        public int? PbfCntr { get; set; }
    }
}
