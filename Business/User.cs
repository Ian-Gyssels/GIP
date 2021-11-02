using System;

namespace Business
{
    public class User
    {
        #region velden
        private int _gebruikersID;
        private String _username;
        private String _wachtwoord;
        private String _salt;
        private String _email;
        private bool _isAdmin;
        private DateTime _geboorteDatum;
        #endregion

        #region constructor
        public User(int gebruikersID,
            string username,
            string wachtwoord,
            string salt,
            string email,
            bool isAdmin,
            DateTime geboorteDatum)
        {
            _gebruikersID = gebruikersID;
            _username = username;
            _wachtwoord = wachtwoord;
            _salt = salt;
            _email = email;
            _isAdmin = isAdmin;
            _geboorteDatum = geboorteDatum;
        }
        #endregion

        #region properties
        public string Username { get => _username; set => _username = value; }
        public bool IsAdmin { get => _isAdmin; set => _isAdmin = value; }
        public int GebruikersID { get => _gebruikersID; set => _gebruikersID = value; }
        public string Email { get => _email; set => _email = value; }
        public string Salt { get => _salt; set => _salt = value; }
        public string Wachtwoord { get => _wachtwoord; set => _wachtwoord = value; }
        public DateTime GeboorteDatum { get => _geboorteDatum; set => _geboorteDatum = value; }
        #endregion

        public override string ToString()
        {
            return Username;
        }
    }
}
