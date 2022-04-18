using Claims2.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claims2.ServiceLayer
{
    public class ClaimOrderService
    {
        private ClaimsContext ctx = new ClaimsContext();
        ClaimOrder _claimOrder {  get; set; }

        public Product1 Product { get; set; }

        public ClaimOrderService(int ClaimOrderId )
        {
            _claimOrder = ctx.ClaimOrders.First(x => x.ClaimOrderId == ClaimOrderId);
            Product = ctx.Products1.First(x => x.ProductId == _claimOrder.ProductId);
        }

        public ClaimOrderService(ClaimOrder co)
        {
            _claimOrder = co;
            Product = ctx.Products1.First(x => x.ProductId == _claimOrder.ProductId);
        }

        public LineItemCategory Category
        {
            get { return (LineItemCategory)Product.LineItemCategory; }
        }


        public ClaimOrder ClaimOrder { get { return _claimOrder; } }


        public static List<ClaimOrderService> GetClaimOrderServices(int claimID)
        {
            var ctx = new ClaimsContext();
            var orderServices = new List<ClaimOrderService>();
            var claimOrders = ctx.ClaimOrders.Where(x => x.InsuranceClaimId == claimID).ToList();

            Parallel.ForEach(claimOrders, claimOrder =>
            {
                orderServices.Add(new ClaimOrderService(claimOrder.ClaimOrderId));
            });

            return orderServices;
        }
    }
}
