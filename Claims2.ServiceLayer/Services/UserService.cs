using Claims2.DataLayer.Models;
using System.Security.Claims;

namespace Claims2.ServiceLayer;

public class UserService
{

    public UserService()
    {
        db = new ClaimsContext();
    }

    private ClaimsContext db;
    private ClaimsPrincipal? _claimsPrincipal;

    public string UserName => _claimsPrincipal.Identity.Name.Split('\\')[1];

    public User2 User => _user;
    private User2? _user;

    public List<InsuranceClaim1> Claims()
    {
        return db.InsuranceClaims1.Where(x => x.Closed != false && x.UserId == User.UserId).ToList();
    }

    


    public void SetIdentity(ClaimsPrincipal claims)
    {
        _claimsPrincipal = claims;

        // Once the claims principal is received,
        // we use the username to login to the 
        // SBS system via the DB.
        LoginToSBSDatabase();
        

    }


    private void LoginToSBSDatabase()
    {
        _user = db.Users2.SingleOrDefault(x => x.Ntlogon == UserName) ?? throw new Exception($"No User found for username: {UserName}");
    }


}