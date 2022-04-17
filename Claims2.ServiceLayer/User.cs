using Claims2.DataLayer.Models;

namespace Claims2.ServiceLayer;

public class User
{
    public List<InsuranceClaim> Claims()
    {
        var db = new ClaimsContext();
        // TODO FIXME change to be proper
        return new List<InsuranceClaim>() { db.InsuranceClaims.First(x => x.DateContacted == null) };
    }
}