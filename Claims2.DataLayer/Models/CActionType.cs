using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class CActionType
    {
        public int ActionTypeId { get; set; }
        public string ActionTypeName { get; set; } = null!;
    }
}
