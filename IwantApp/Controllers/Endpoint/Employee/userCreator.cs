using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

internal class userCreator
{
    internal static Task<(IdentityResult identity, string userId)> Create(string email, string password, List<Claim> userClaims)
    {
        throw new NotImplementedException();
    }
}