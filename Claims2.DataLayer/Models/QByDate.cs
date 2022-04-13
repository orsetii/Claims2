using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class QByDate
    {
        public int? Clid { get; set; }
        public string? Cldate { get; set; }
        public string? Cllaref { get; set; }
        public string? ClclaimType { get; set; }
        public string? Cltype { get; set; }
        public string? ClclaimHandler { get; set; }
        public string? Clcurrentstatus { get; set; }
    }
}
