using Home.Domain;

namespace Home.Service.Interfaces;

public interface IAuthenticationService
{
    /// <summary>
    /// Checks if provided password matches the password stored in the user
    /// </summary>
    /// <param name="user">User to validate</param>
    /// <param name="password">Password provided from outside, will be compared with user password</param>
    /// <returns></returns>
    bool UserCredentialsValid(User user, string password);

    /// <summary>
    /// Creates valid JWT for user
    /// </summary>
    /// <param name="user">Will be used to derive values to encode in the token</param>
    /// <returns></returns>
    string CreateAuthenticationToken(User user);
}