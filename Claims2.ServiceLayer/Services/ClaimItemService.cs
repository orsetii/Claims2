using Claims2.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claims2.ServiceLayer.Services
{
    public class ClaimItemService
    {
        private ClaimItem _claimItem { get; set; }
        private Product1? _product { get; set; }
        public Product1? Product => _product;
        private ClaimsContext ctx = new ClaimsContext();

        public ClaimItem ClaimItem => _claimItem;
        public ClaimItemService(int claimItemID)
        {
            _claimItem = ctx.ClaimItems.First(x => x.ItemId == claimItemID);
            _product = ctx.Products1.SingleOrDefault(x => x.ProductId == ClaimItem.ProductId);
        }




        public override string ToString()
        {
            // TODO FIXME Wrong field
            return Product?.Description ?? "";
        }

    }
}
