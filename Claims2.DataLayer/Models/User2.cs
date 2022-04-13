using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class User2
    {
        public User2()
        {
            AutoAssignmentResultAssignedByUsers = new HashSet<AutoAssignmentResult>();
            AutoAssignmentResultUsers = new HashSet<AutoAssignmentResult>();
            Documents = new HashSet<Document>();
            Groups = new HashSet<Group>();
            LoginHistories = new HashSet<LoginHistory>();
            Notifications = new HashSet<Notification>();
            PrintQueueDocumentAddedByNavigations = new HashSet<PrintQueueDocument>();
            PrintQueueDocumentRemovedByNavigations = new HashSet<PrintQueueDocument>();
            PrintQueueHistories = new HashSet<PrintQueueHistory>();
            TaskHistories = new HashSet<TaskHistory>();
            UserCommodities = new HashSet<UserCommodity>();
            UserComplaintCompensations = new HashSet<UserComplaintCompensation>();
            UserCreditRecs = new HashSet<UserCreditRec>();
            UserGroup1s = new HashSet<UserGroup1>();
            UserInsuranceCompanies = new HashSet<UserInsuranceCompany>();
            UserInvoiceErrors = new HashSet<UserInvoiceError>();
            UserRole1s = new HashSet<UserRole1>();
            UserScores = new HashSet<UserScore>();
            UserTimekeepings = new HashSet<UserTimekeeping>();
            Warranties = new HashSet<Warranty>();
        }

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
        public bool EmailAlerts { get; set; }
        public bool? IsClaimHandler { get; set; }
        public DateTime? LastActive { get; set; }
        public byte[]? ThumbnailDisplayPicture { get; set; }
        public byte[]? DisplayPicture { get; set; }
        public string? DisplayPictureMime { get; set; }
        public int? Status { get; set; }
        public DateTime? LastEmailImported { get; set; }

        public virtual UserStatus? StatusNavigation { get; set; }
        public virtual ICollection<AutoAssignmentResult> AutoAssignmentResultAssignedByUsers { get; set; }
        public virtual ICollection<AutoAssignmentResult> AutoAssignmentResultUsers { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<LoginHistory> LoginHistories { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<PrintQueueDocument> PrintQueueDocumentAddedByNavigations { get; set; }
        public virtual ICollection<PrintQueueDocument> PrintQueueDocumentRemovedByNavigations { get; set; }
        public virtual ICollection<PrintQueueHistory> PrintQueueHistories { get; set; }
        public virtual ICollection<TaskHistory> TaskHistories { get; set; }
        public virtual ICollection<UserCommodity> UserCommodities { get; set; }
        public virtual ICollection<UserComplaintCompensation> UserComplaintCompensations { get; set; }
        public virtual ICollection<UserCreditRec> UserCreditRecs { get; set; }
        public virtual ICollection<UserGroup1> UserGroup1s { get; set; }
        public virtual ICollection<UserInsuranceCompany> UserInsuranceCompanies { get; set; }
        public virtual ICollection<UserInvoiceError> UserInvoiceErrors { get; set; }
        public virtual ICollection<UserRole1> UserRole1s { get; set; }
        public virtual ICollection<UserScore> UserScores { get; set; }
        public virtual ICollection<UserTimekeeping> UserTimekeepings { get; set; }
        public virtual ICollection<Warranty> Warranties { get; set; }
    }
}
