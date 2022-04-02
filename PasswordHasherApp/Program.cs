using PasswordHasher;

Console.WriteLine("Welcome to password hasher! Please enter password you would like to hash!");

var hash = Hasher.HashPassword(PasswordRead());
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Password hashed: " + hash);

string PasswordRead()
{
    while (true)
    {
        var passwordToHash = Console.ReadLine();
        if (!string.IsNullOrEmpty(passwordToHash)) return passwordToHash;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Password you entered seems to be empty :-(. Please try again.");
        Console.ForegroundColor = ConsoleColor.White;
    }
}