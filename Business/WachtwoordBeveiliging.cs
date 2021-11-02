using System;
using System.Security.Cryptography;
using System.Text;

namespace Business
{
    public class WachtwoordBeveiliging
    {
        /// <summary>
        /// Zorgt ervoor dat elk wachtwoord als unieke waarde word opgeslagen
        /// </summary>
        /// <param name="lengte">Lengte van de salt</param>
        /// <returns></returns>
        public String MaakSalt(int lengte)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[lengte];
            rng.GetBytes(buff);

            return Convert.ToBase64String(buff);
        }


        /// <summary>
        /// Voegt het wachtwoord en salt samen en hasht ze zodat ze onleesbaar zijn voor gewone gebruikers
        /// Doel: Veiligheid in Databank
        /// </summary>
        /// <param name="input">Wachtwoord</param>
        /// <param name="salt">Salt --> uit Maaksalt(int)</param>
        /// <returns>unieke hash voor wachtwoord</returns>
        public String MaakSHA256Hash(String input, String salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
            SHA256Managed sHA256HashString = new SHA256Managed();
            byte[] hash = sHA256HashString.ComputeHash(bytes);
            String hashed = BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();

            return hashed;
        }
    }
}
