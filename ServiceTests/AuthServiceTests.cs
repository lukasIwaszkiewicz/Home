using Home.Domain;
using Home.Service;
using Xunit;

namespace ServiceTests;

public class AuthServiceTests
{
    [Fact]
    public void UserCredentialsShouldBeValid()
    {
        var authService = new AuthenticationService();
        var user = new User(1, "a", "40n+0TKZzLgyFGnUA3PaBn344/qjTSdeYbWB3xRzm7g=");
        var result = authService.UserCredentialsValid(user, "lukas");
        Assert.True(result);
    }
}