using System;
using System.IO;

namespace Debug.Three;
public class UserManager
{
    private Logger logger = new Logger();

    public User CreateUser(string name, string email)
    {
        if (string.IsNullOrEmpty(email))
        {
            throw new ArgumentException("E-post kan inte vara tom.");
        }

        return new User { Name = name, Email = email };
    }

    public void DisplayUser(User user)
    {
        Console.WriteLine($"Användarnamn: {user.Name}");
        Console.WriteLine($"E-post: {user.Email}");
    }

    public void LoadUserSettings(User user)
    {
        string filePath = $"./{user.Name}_settings.txt";
        if (!File.Exists(filePath))
        {
            logger.Log("Filen existerar inte. Skapar en ny inställningsfil.");
            File.WriteAllText(filePath, "Default Settings");
        }

        string settings = File.ReadAllText(filePath);
        Console.WriteLine($"{user.Name}'s Inställningar: {settings}");
    }
}
