using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class PoExceptionType
    {
        public int PoetCode { get; set; }
        public string PoetDescription { get; set; } = null!;
    }
}
