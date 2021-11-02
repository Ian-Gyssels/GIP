using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using Business;

namespace DataAccess
{
    public class GebruikersDA
    {
        #region velden
        private readonly String _connString;
        private MySqlConnection _mySqlConnection;
        private WachtwoordBeveiliging _passwordProtection;
        #endregion

        #region construction
        public GebruikersDA()
        {
            _connString = "server=localhost;user id=root;database=gip2";

            _mySqlConnection = new MySqlConnection(_connString);

            _passwordProtection = new WachtwoordBeveiliging();
        }
        #endregion

        #region database
        /// <summary>
        /// haalt alle gebruikers uit de database
        /// </summary>
        /// <returns></returns>
        public List<User> ReadTable()
        {

            List<User> lijst = new List<User>();

            String sql = $"select * from tblgebruikers;";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            _mySqlConnection.Open();

            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read() == true)
            {
                User user = new User((int)(mySqlDataReader["GebruikerID"]),
                                                                (mySqlDataReader["Username"].ToString()),
                                                                (mySqlDataReader["Wachtwoord"].ToString()),
                                                                mySqlDataReader["Salt"].ToString(),
                                                                (mySqlDataReader["Emai"].ToString()),
                                                                Convert.ToBoolean((mySqlDataReader["IsAdmin"])),
                                                                (DateTime)(mySqlDataReader["GeboorteDatum"]));

                lijst.Add(user);
            }

            _mySqlConnection.Close();

            return lijst;
        }

        /// <summary>
        /// haalt alle gebruikersnamen uit de database
        /// </summary>
        /// <returns>Lijst met alle gebruikersnamen</returns>
        public List<String> ReadUsername()
        {

            List<String> lijst = new List<String>();

            String sql = $"select `Username` from tblgebruikers;";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            _mySqlConnection.Open();

            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read() == true)
            {
                String username = (mySqlDataReader["Username"].ToString());

                lijst.Add(username);
            }

            _mySqlConnection.Close();

            return lijst;
        }

        /// <summary>
        /// geeft elke gebruikersnaam die overeenkomt met een deel van de meegegeven waarde
        /// </summary>
        /// <param name="naam">Deel van de gebruikersnaam</param>
        /// <returns>Lijst ban gebruikersnamen</returns>
        public List<String> FilterDeelVanUsername(String naam)
        {

            List<String> lijst = new List<String>();

            String sql = $"select `Username` from tblgebruikers where `Username` Like '%{naam}%';";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            _mySqlConnection.Open();

            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read() == true)
            {
                String username = (mySqlDataReader["Username"].ToString());

                lijst.Add(username);
            }

            _mySqlConnection.Close();

            return lijst;
        }

        /// <summary>
        /// haalt gebruikers uit de database et behulp van de megegeven sql code
        /// </summary>
        /// <param name="sql">sql Commando</param>
        /// <returns>Lijst van gebruikers</returns>
        public List<User> FilterTable(String sql)
        {
            List<User> lijst = new List<User>();


            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            _mySqlConnection.Open();

            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read() == true)
            {
                User user = new User((int)(mySqlDataReader["GebruikerID"]),
                                                                (mySqlDataReader["Username"].ToString()),
                                                                (mySqlDataReader["Wachtwoord"].ToString()),
                                                                mySqlDataReader["Salt"].ToString(),
                                                                (mySqlDataReader["Emai"].ToString()),
                                                                Convert.ToBoolean((mySqlDataReader["IsAdmin"])),
                                                                (DateTime)(mySqlDataReader["GeboorteDatum"]));

                lijst.Add(user);
            }

            _mySqlConnection.Close();

            return lijst;
        }

        /// <summary>
        /// haalt 1 gebruiker uit de database
        /// </summary>
        /// <param name="username">gebruikersnaam van de gewenste gebruiker</param>
        /// <returns>1 gebruiker</returns>
        public User FilterTableUserName(String username)
        {
            User user = null;

            String sql = $"select * from tblgebruikers where `Username` = '{username}';";

            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            _mySqlConnection.Open();

            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read() == true)
            {
                user = new User((int)(mySqlDataReader["GebruikerID"]),
                                                            (mySqlDataReader["Username"].ToString()),
                                                            (mySqlDataReader["Wachtwoord"].ToString()),
                                                            mySqlDataReader["Salt"].ToString(),
                                                            (mySqlDataReader["Emai"].ToString()),
                                                            Convert.ToBoolean((mySqlDataReader["IsAdmin"])),
                                                            (DateTime)(mySqlDataReader["GeboorteDatum"]));
            }
            _mySqlConnection.Close();

            return user;
        }

        /// <summary>
        /// past de gegevens aan van een gebruiker in de database
        /// </summary>
        /// <param name="user">de gebruiker met aangepaste gegevens</param>
        public void UpdateRecord(User user)
        {
            String sql = "Update tblgebruikers set `Username` = @Username," +
                        " `Wachtwoord` = @Wachtwoord," +
                        " `Salt` = @Salt," +
                        " `Emai` = @Emai," +
                        " `IsAdmin` = @IsAdmin," +
                        " `GeboorteDatum` = @GeboorteDatum" +
                        " where (`GebruikerID` = @GebruikerID)";

            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            mySqlCommand.Parameters.AddWithValue("@Username", user.Username);
            mySqlCommand.Parameters.AddWithValue("@Wachtwoord", user.Wachtwoord);
            mySqlCommand.Parameters.AddWithValue("@Salt", user.Salt);
            mySqlCommand.Parameters.AddWithValue("@Emai", user.Email);
            mySqlCommand.Parameters.AddWithValue("@IsAdmin", Convert.ToInt32(user.IsAdmin));
            mySqlCommand.Parameters.AddWithValue("@GeboorteDatum", user.GeboorteDatum);
            mySqlCommand.Parameters.AddWithValue("@GebruikerID", user.GebruikersID);

            _mySqlConnection.Open();

            mySqlCommand.ExecuteNonQuery();

            _mySqlConnection.Close();
        }

        /// <summary>
        /// maakt een nieuwe gebruiker aan in de database
        /// </summary>
        /// <param name="user">Nieuwe gebruiker</param>
        public void CreateRecord(User user)
        {
            //SQL instructie
            String sql = "Insert into tblgebruikers (`Username`,`Wachtwoord`,`Salt`,`Emai`,`IsAdmin`,`GeboorteDatum`) " +
                "Values(@Username, @Wachtwoord, @Salt, @Emai, @IsAdmin, @GeboorteDatum);";

            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);


            mySqlCommand.Parameters.AddWithValue("@Username", user.Username);
            mySqlCommand.Parameters.AddWithValue("@Wachtwoord", user.Wachtwoord);
            mySqlCommand.Parameters.AddWithValue("@Salt", user.Salt);
            mySqlCommand.Parameters.AddWithValue("@Emai", user.Email);
            mySqlCommand.Parameters.AddWithValue("@IsAdmin", Convert.ToInt32(user.IsAdmin));
            mySqlCommand.Parameters.AddWithValue("@GeboorteDatum", user.GeboorteDatum);


            _mySqlConnection.Open();

            mySqlCommand.ExecuteNonQuery();

            _mySqlConnection.Close();
        }

        /// <summary>
        /// verwijderd een gebruiker in de database met behulp van een id
        /// </summary>
        /// <param name="id">ID van de gebruiker die je wil verwijderen</param>
        public void DeleteRecord(int id)
        {
            String sql = "Delete from tblgebruikers where (`GebruikerID` = @GebruikerID);";

            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            mySqlCommand.Parameters.AddWithValue("@GebruikerID", id);

            _mySqlConnection.Open();

            mySqlCommand.ExecuteNonQuery();

            _mySqlConnection.Close();
        }
        #endregion  
    }
}
