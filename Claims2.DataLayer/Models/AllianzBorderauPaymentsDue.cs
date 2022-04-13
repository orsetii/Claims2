using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class AllianzBorderauPaymentsDue
    {
        public DateTime? ClaimDate { get; set; }
        public string? InsuredName { get; set; }
        public string? InsuredAddressInclPostcode { get; set; }
        public double? InsurerClaimRef { get; set; }
        public string? InsurerIECornhillDirectAllianzCornhillOrBritannic { get; set; }
        public double? SbsRef { get; set; }
        public string? InsurerIECornhillDirectAllianzCornhillOrBritannicNo { get; set; }
        public double? ElectricalPhotographic { get; set; }
        public double? Multimedia { get; set; }
        public double? Computers { get; set; }
        public double? Telephony { get; set; }
        public double? MusicalInstruments { get; set; }
        public double? Golf { get; set; }
        public double? Tools { get; set; }
        public double? FloorCoverings { get; set; }
        public double? Jewellery { get; set; }
        public double? JewelleryHnwOrAsian { get; set; }
        public double? Bikes { get; set; }
        public double? Fishing { get; set; }
        public double? FireRestorationExclLaundry { get; set; }
        public double? FloodRestorationExclLaundry { get; set; }
        public double? Laundry { get; set; }
        public double? OtherWorks { get; set; }
        public double? Glass { get; set; }
        public double? FrameRepair { get; set; }
        public double? FrameReplacement { get; set; }
        public double? GarageDoors { get; set; }
        public double? LocksSecuring { get; set; }
        public double? Conservatories { get; set; }
        public double? Works { get; set; }
        public double? ValidationFees { get; set; }
        public double? AmountStillOutstanding { get; set; }
        public double? OriginalInvoiceAmountInclFees { get; set; }
        public string? XSDeductedYNOrPdIfPreviouslyDeducted { get; set; }
        public double? TotalToBePaidNetOfExcess { get; set; }
        public double? XSAmount { get; set; }
        public string? XSCollectedYNNoNeedToCompleteThisColumnJustHideAs { get; set; }
        public double? BettermentAmount { get; set; }
        public double? InvoiceNumber { get; set; }
        public double? TotalThisNeedToBeCompletedButIsTheSameAsTotalToBe { get; set; }
        public string? InterimFinalSupplementaryFinalOrRepudiation { get; set; }
        public string? Comments { get; set; }
    }
}
