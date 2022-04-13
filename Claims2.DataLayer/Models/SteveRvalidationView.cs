using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SteveRvalidationView
    {
        public string AccountName { get; set; } = null!;
        public string InstructingOffice { get; set; } = null!;
        public int? SbsclaimId { get; set; }
        public int ItemId { get; set; }
        public string? PolicyNumber { get; set; }
        public string Lareference { get; set; } = null!;
        public string? PostCode { get; set; }
        public DateTime ValidationClaimCreated { get; set; }
        public DateTime DateSubmittedToSbs { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string Username { get; set; } = null!;
        public string? InsuredFirstName { get; set; }
        public string? InsuredLastName { get; set; }
        public string? InsuredAddress1 { get; set; }
        public string? InsuredAddress2 { get; set; }
        public string? InsuredAddress3 { get; set; }
        public string? InsuredAddress4 { get; set; }
        public string? Telephone { get; set; }
        public decimal? PolicyExcess { get; set; }
        public decimal? SingleArticleLimit { get; set; }
        public DateTime? IncidentDate { get; set; }
        public string? ItemType { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? ChosenOutcomeName { get; set; }
        public string? PurchasePrice { get; set; }
        public string? ShortDescription { get; set; }
        public decimal? ReplacementCost { get; set; }
        public decimal? ReplacementSell { get; set; }
        public decimal? Expr1 { get; set; }
        public string? SupplierName { get; set; }
    }
}
