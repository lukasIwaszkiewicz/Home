using System.Buffers.Text;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace PasswordHasher;

public static class Hasher
{
    public static string HashPassword(string password)
    {
        var result = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password, Array.Empty<byte>(), KeyDerivationPrf.HMACSHA256, 10000, 256 / 8
        ));

        return result;
    }
}