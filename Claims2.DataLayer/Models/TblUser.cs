using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class TblUser
    {
        public int UserId { get; set; }
        public string? VendorCode { get; set; }
        public string UserName { get; set; } = null!;
        public string? UserPassword { get; set; }
        public string? TitleName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserType { get; set; }
        public int? UserPrivileges { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public bool Notify { get; set; }
        public bool Manager { get; set; }
        public bool Accountant { get; set; }
        public string? Ntlogon { get; set; }
    }
}
