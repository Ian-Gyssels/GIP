using MailKit.Net.Smtp;
using MimeKit;
using System;

namespace Business
{
    public class MailService
    {
        #region velden
        private readonly String _van = "nmbsgip@gmail.com";
        private readonly String _wachtwoord = "Hfi12345";
        #endregion

        #region mail
        /// <summary>
        /// Geheime code voor wachtwoordherstel
        /// </summary>
        /// <param name="naar">email gebruiker</param>
        /// <param name="gebruiker">gebruikersnaam</param>
        /// <param name="code">Geheime code</param>
        public void StuurCode(String naar, String gebruiker, String code)
        {
            MimeMessage message = new MimeMessage();

            message.From.Add(new MailboxAddress(_van)); //emailadress van
            message.To.Add(new MailboxAddress(naar)); // emailAdress naar

            message.Subject = "Hier is je geheime code";

            message.Body = new TextPart("plain")
            {
                Text = $@"Beste {gebruiker}

Hier is je geheime code: {code}
------------------------------------------------------------------------------------------------------
Als u verdere vragen heeft of problemen ondervind kan je ons bereiken op email: nmbsgip@gmail.com"
            };

            using (var client = new SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                client.Connect("smtp.gmail.com", 587);

                client.Authenticate(_van, _wachtwoord);

                client.Send(message);

                client.Disconnect(true);
            }
        }

        /// <summary>
        /// nieuwe gegevens van gebruiker doorsturen
        /// </summary>
        /// <param name="username">gebruikersnaam</param>
        /// <param name="email">email</param>
        /// <param name="wachtwoord">wachtwoord</param>
        /// <param name="user">gebruiker</param>
        /// <param name="nieuwWachtwoord">aanduiding of er een nieuw wachtwoord is</param>
        public void StuurGegevens(String username, String email, String wachtwoord, User user, bool nieuwWachtwoord)
        {
            MimeMessage message = new MimeMessage();

            message.From.Add(new MailboxAddress(_van)); //emailadress van
            message.To.Add(new MailboxAddress(email)); // emailAdress naar

            message.Subject = "Uw gegevens werden gewijzigd";

            if (nieuwWachtwoord)
            {
                message.Body = new TextPart("plain")
                {
                    Text = $@"Beste {username}

Een administrator heeft enkele gegevens van uw account veranderd, hieronder vindt u uw nieuwe gegevens
------------------------------------------------------------------------------------------------------
Gebruikersnaam : {user.Username}
Email : {user.Email}
Geboortedatum : {user.GeboorteDatum}
Wachtwoord : {wachtwoord}
Admin : {IsAdminText(user.IsAdmin)}
------------------------------------------------------------------------------------------------------
Als u verdere vragen heeft of problemen ondervind kan je ons bereiken op email: nmbsgip@gmail.com"
                };
            }
            else
            {
                message.Body = new TextPart("plain")
                {
                    Text = $@"Beste {username}

Een administrator heeft enkele gegevens van uw account veranderd, hieronder vindt u uw nieuwe gegevens
------------------------------------------------------------------------------------------------------
Gebruikersnaam : {user.Username}
Email : {user.Email}
Geboortedatum : {user.GeboorteDatum}
Admin : {IsAdminText(user.IsAdmin)}
------------------------------------------------------------------------------------------------------
Als u verdere vragen heeft of problemen ondervind kan je ons bereiken op email: nmbsgip@gmail.com"
                };
            }

            using (var client = new SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                client.Connect("smtp.gmail.com", 587, false);
                client.AuthenticationMechanisms.Remove("XOAUTH2");

                client.Authenticate(_van, _wachtwoord);

                client.Send(message);

                client.Disconnect(true);
            }
        }

        /// <summary>
        /// stuurt email naar gebruiker om te laten weten dat de gebruiker verwijderd is
        /// </summary>
        /// <param name="naar">email gebruiker</param>
        /// <param name="gebruiker">gebruikersnaam</param>
        public void StuurVerwijderd(String naar, String gebruiker)
        {
            MimeMessage message = new MimeMessage();

            message.From.Add(new MailboxAddress(_van)); //emailadress van
            message.To.Add(new MailboxAddress(naar)); // emailAdress naar

            message.Subject = "Je account is verwijderd ";

            message.Body = new TextPart("plain")
            {
                Text = $@"Beste {gebruiker}

Een administrator heeft uw account verwijderd.
Sorry voor dit ongemak.
------------------------------------------------------------------------------------------------------
Als u verdere vragen heeft of problemen ondervind kan je ons bereiken op email: nmbsgip@gmail.com"
            };

            using (var client = new SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                client.Connect("smtp.gmail.com", 587);

                client.Authenticate(_van, _wachtwoord);

                client.Send(message);

                client.Disconnect(true);
            }
        }
        #endregion

        private String IsAdminText(bool admin)
        {
            if (admin)
            {
                return "Ja";
            }
            else
            {
                return "Nee";
            }
        }
    }
}
