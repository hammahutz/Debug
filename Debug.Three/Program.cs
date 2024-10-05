namespace Debug.Three;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program startat.");

        UserManager userManager = new UserManager();
        Logger logger = new Logger();

        try
        {
            logger.Log("Skapar en ny användare.");
            User user = userManager.CreateUser("Alice", "alice@example.com");

            logger.Log("Visar användarinformation.");
            userManager.DisplayUser(user);

            // Introducera en bugg genom att försöka läsa en icke-existerande fil
            logger.Log("Försöker läsa användarens inställningar från en fil.");
            userManager.LoadUserSettings(user);

            // Introducera en annan bugg genom att skapa en användare utan e-post
            logger.Log("Försöker skapa en användare utan e-post (ska kasta undantag).");
            User invalidUser = userManager.CreateUser("Bob", ""); // Bugg här!
        }
        catch (Exception ex)
        {
            logger.Log($"Ett undantag inträffade: {ex.Message}");
        }

        Console.WriteLine("Programmet avslutades.");
    }
}