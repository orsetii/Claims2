using Claims2.DataLayer.Models;
using Claims2.ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claims2.ServiceLayer
{
    public class ClaimService
    {
        private InsuranceClaim1 _claim { get; set; }
        private ClaimsContext ctx = new ClaimsContext();
        public ClaimService(int claimID)
        {
            _claim = ctx.InsuranceClaims1.First(x => x.InsuranceClaimId == claimID);
            _claimItemServices = GetClaimItemServices();
        }


        public List<ClaimOrder> claimOrders
        {
            get 
            {
                return ctx.ClaimOrders
                    .Where( x => x.InsuranceClaimId == _claim.InsuranceClaimId)
                    .ToList(); 
            }
        }

        public InsuranceClaim1 Claim { get { return _claim; } }

        private List<ClaimItemService> _claimItemServices;
        public List<ClaimItemService> ClaimItemServices => _claimItemServices;

        private List<ClaimItemService> GetClaimItemServices()
        {
            var ctx = new ClaimsContext();
            var itemServices = new List<ClaimItemService>();
            var claimItems = ctx.ClaimItems.Where(x => x.InsuranceClaimId == _claim.InsuranceClaimId).ToList();

            Parallel.ForEach(claimItems, claimItem =>
            {
                itemServices.Add(new ClaimItemService(claimItem.ItemId));
            });

            return itemServices;
        }

    }
}
