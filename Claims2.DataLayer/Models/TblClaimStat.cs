using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class TblClaimStat
    {
        public int Id { get; set; }
        public int InsuranceClaimId { get; set; }
        public int ClaimItemId { get; set; }
        public DateTime? Instructionbookedonfnol { get; set; }
        public DateTime? Instructionbookedonip { get; set; }
        public DateTime? Instructionbookedonipautomaticly { get; set; }
        public DateTime? Instructionpickedup { get; set; }
        public DateTime? Inspectionreadbyengineer { get; set; }
        public DateTime? Dateinspectionacknowledged { get; set; }
        public DateTime? Daterepairread { get; set; }
        public DateTime? Handlerreadprintedreport { get; set; }
        public DateTime? Inspectioncreated { get; set; }
        public DateTime? Goodsrecivedcalloutbooked { get; set; }
        public DateTime? Inspectionreported { get; set; }
        public DateTime? Berack { get; set; }
        public DateTime? Repairauth { get; set; }
        public DateTime? Inspcancelled { get; set; }
        public DateTime? Repaircomplete { get; set; }
        public DateTime? Repairfailed { get; set; }
        public DateTime? Phonecontactwithpolicyholder { get; set; }
        public DateTime? Secondphonecontactwithpolicyholder { get; set; }
        public DateTime? Firstcontactletter { get; set; }
        public DateTime? Secondcontactletter { get; set; }
        public DateTime? Thirdcontactletter { get; set; }
        public DateTime? Bitoolused { get; set; }
        public DateTime? Variationtoinstructionph { get; set; }
        public DateTime? Variationtoinstructionic { get; set; }
        public DateTime? Variationtoinstructionii { get; set; }
        public DateTime? Excesscollected { get; set; }
        public DateTime? Smsemailtoph { get; set; }
        public DateTime? Nondelivery { get; set; }
        public DateTime? Invoiceinterim { get; set; }
        public DateTime? Invoicefinal { get; set; }
        public DateTime? Closeclaim { get; set; }
        public DateTime? Validationtool { get; set; }
        public DateTime? Carpetsample { get; set; }
        public DateTime? Inspectionreportto { get; set; }
        public DateTime? Quotetoinsurance { get; set; }
        public DateTime? Recommendrepudiation { get; set; }
        public DateTime? Bettermentagreed { get; set; }
        public DateTime? Instructiontonotrepair { get; set; }
        public DateTime? Repaireditemreturned { get; set; }
        public DateTime? Carpetdryingstarted { get; set; }
        public DateTime? Carpetdryingcompleted { get; set; }
        public DateTime? Carpetvoucherissued { get; set; }
        public DateTime? Carpetvoucherredeemed { get; set; }
        public DateTime? Replacementgoodsordered { get; set; }
        public DateTime? Additionalgoodsordered { get; set; }
        public DateTime? Claimitemwithdrawnbyph { get; set; }
        public DateTime? Claimitemwithdrawnbyic { get; set; }
        public DateTime? Claimitemrepudiated { get; set; }
        public DateTime? Itemreadytobeinvoiced { get; set; }
        public DateTime? Cashsettledbyinsurancecompany { get; set; }
        public DateTime? Cashsettledbysbs { get; set; }
        public DateTime? Purchaseorderraised { get; set; }
        public DateTime? Assignoutcome { get; set; }
        public DateTime? Deadonarrival { get; set; }
        public DateTime? Failedrepair { get; set; }
        public DateTime? Customerrejectedsettlement { get; set; }
        public DateTime? Cancelledduringtransit { get; set; }
        public DateTime? Incorrectitemsupplied { get; set; }
        public DateTime? Awaitingproofofpurchase { get; set; }
        public DateTime? Inspectionarranged { get; set; }
        public DateTime? Engineerbooked { get; set; }
        public DateTime? Closeitem { get; set; }
        public DateTime? Carpetfitted { get; set; }
        public DateTime? Awaitingfittingdate { get; set; }
        public DateTime? Replacementflooroffered { get; set; }
        public DateTime? Cleaninprogress { get; set; }
        public DateTime? Awaitingcarpetsample { get; set; }
        public DateTime? Sourcingpartsormaterialforrepair { get; set; }
        public DateTime? Repairoffered { get; set; }
        public DateTime? Voucherissued { get; set; }
        public DateTime? Repairtobecarriedout { get; set; }
        public DateTime? Voucheroffered { get; set; }
        public DateTime? Repairtobecarriedoutgiftware { get; set; }
        public DateTime? Sourcingpartsforrepair { get; set; }
        public DateTime? Repairtobecarriedoutjewellry { get; set; }
        public DateTime? Repairtobecarriedoutwatch { get; set; }
        public DateTime? Sourcingpartsforrepairjewellry { get; set; }
        public DateTime? Mandatesent { get; set; }
        public DateTime? Telesale { get; set; }
        public DateTime? Lastitemdeldate { get; set; }
        public DateTime? Repairreqsent { get; set; }
        public DateTime? Repaircompletedate { get; set; }
        public DateTime? Replaceddate { get; set; }
    }
}
