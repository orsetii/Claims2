using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Agent
    {
        public int AgentId { get; set; }
        public string AgentName { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool Enabled { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public DateTime DateCreated { get; set; }
        public string? CreatedBy { get; set; }
    }
}
