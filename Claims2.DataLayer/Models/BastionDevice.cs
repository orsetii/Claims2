using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BastionDevice
    {
        public int BdId { get; set; }
        public int ClaimId { get; set; }
        public int DeviceTypeId { get; set; }
        public string DeviceType { get; set; } = null!;
        public DateTime LogDate { get; set; }
    }
}
