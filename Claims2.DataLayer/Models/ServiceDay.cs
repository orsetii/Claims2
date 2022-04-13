using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ServiceDay
    {
        public int Id { get; set; }
        /// <summary>
        /// 0 is Sunday.
        /// </summary>
        public int DayOfWeek { get; set; }
        public int ServiceId { get; set; }
        public string? PostCode { get; set; }
        public int SupplierId { get; set; }

        public virtual Service Service { get; set; } = null!;
        public virtual Supplier1 Supplier { get; set; } = null!;
    }
}
