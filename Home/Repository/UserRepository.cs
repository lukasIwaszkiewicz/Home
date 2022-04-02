using Home.Domain;
using Home.Repository.Interfaces;

namespace Home.Repository;

public class UserRepository : IUserRepository
{
    private readonly List<User> _users = new()
    {
        new User(1, "iwanezp@gmail.com", "40n+0TKZzLgyFGnUA3PaBn344/qjTSdeYbWB3xRzm7g=")
    };


    public async Task<User?> GetByEmail(string email)
    {
        var user = await Task.Run(() => _users.FirstOrDefault(x => StringCompareCaseInsensitive(x.Email, email)));
        return user;
    }

    private bool StringCompareCaseInsensitive(string a, string b)
    {
        return string.Equals(a, b, StringComparison.CurrentCultureIgnoreCase);
    }
}