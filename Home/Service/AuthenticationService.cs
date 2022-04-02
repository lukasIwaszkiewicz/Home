using Home.Domain;
using Home.Service.Interfaces;
using PasswordHasher;

namespace Home.Service;

public class AuthenticationService : IAuthenticationService
{
    public bool UserCredentialsValid(User user, string password)
    {
        var passwordHash = Hasher.HashPassword(password);
        return !passwordHash.Where((t, i) => t != user.Password[i]).Any();
    }

    public string CreateAuthenticationToken(User user)
    {
        throw new NotImplementedException();
    }
}