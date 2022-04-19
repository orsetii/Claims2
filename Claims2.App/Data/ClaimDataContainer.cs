using Claims2.ServiceLayer;
using MudBlazor;

namespace Claims2.App.Data
{
    public class ClaimDataContainer
    {
        private ClaimViewData? savedObj;

        public ClaimViewData Property
        {
            get => savedObj;
            set
            {
                savedObj = value;
                NotifyStateChanged();
            }
        }

        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }

    public class ClaimViewData
    {
        public ClaimService Claim { get; set; }

        public List<ClaimOrderService>? ClaimOrderServices { get; set; }


        public ClaimViewData(int claimID)
        {
            Claim = new ClaimService(claimID);
        }
        
        public string GetIcon(LineItemCategory category)
        {
            switch (category)
            {
                case LineItemCategory.Fee:
                    return Icons.Material.Filled.Receipt;
                case LineItemCategory.Product:
                    return Icons.Material.Filled.Inventory2;
                case LineItemCategory.Service:
                    return Icons.Material.Filled.BuildCircle;
                default:
                    return Icons.Material.Filled.DeviceUnknown;
            }
        }

        public void GetCOs()
        {
            ClaimOrderServices = ClaimOrderService.GetClaimOrderServices(Claim.Claim.InsuranceClaimId);
        }
    }
}