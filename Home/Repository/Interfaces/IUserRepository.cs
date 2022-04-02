using Home.Domain;

namespace Home.Repository.Interfaces;

public interface IUserRepository
{
    Task<User?> GetByEmail(string email);
}