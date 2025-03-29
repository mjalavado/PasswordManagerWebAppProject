using System.Collections.Generic;
namespace PassManagerAPI.Models
{
    public class Passwords
    {
        public int userId { get; set; }
        public string siteTitle { get; set; } = "";
        public string userName { get; set; } = "";
        public string userPass { get; set; } = "";

        public Passwords(int idUser, string titleSite, string nameUser, string passUser)
        {
            userId = idUser;
            siteTitle = titleSite;
            userName = nameUser;
            userPass = passUser;
        }

        public static List<Passwords> GetCredentials() => new List<Passwords>
        {
            new Passwords( 1234, "YouTube", "mjalavado", "testpass1234"),
            new Passwords( 2222, "Spotify", "matt2507", "spotP@s$7896"),
            new Passwords( 3324, "Gmail", "mattAlavado@gmail.com", "randomPass43123"),
            new Passwords( 4423, "Amazon", "testmail@gmail.com", "ibuystuffforthissite"),
            new Passwords( 5555, "Twitch", "random_user908", "p@s$f0RtW1tcH")
        };
    }
}
