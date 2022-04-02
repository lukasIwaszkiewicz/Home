using Home.Domain;
using Home.Repository.Interfaces;

namespace Home.Repository;

public class UserRepository : IUserRepository
{
    private readonly List<User> _users = new()
    {
        new User
        {
            Id = 1,
            Email = "iwanezp@gmail.com",
            Password = "40n+0TKZzLgyFGnUA3PaBn344/qjTSdeYbWB3xRzm7g="
        }
    };


    public async Task<User> GetByEmail(string email)
    {
        var user = await Task.Run(() =>
            _users.SingleOrDefault(x => StringCompareCaseInsensitive(x.Email, email)));

        return user;
    }

    private bool StringCompareCaseInsensitive(string a, string b)
    {
        return string.Equals(a, b, StringComparison.CurrentCultureIgnoreCase);
    }
}