using Claims2.DataLayer.Models;

namespace Claims2.ServiceLayer;

public class User
{
    public List<InsuranceClaim1> Claims()
    {
        var db = new ClaimsContext();
        // TODO FIXME change to be proper
        return new List<InsuranceClaim1> { db.InsuranceClaims1.First(x => x.InsuranceClaimId != null) };
        
    }
}