using System;
using System.Collections.Generic;
using Business;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public class OpgeslagenDA
    {
        #region velden
        private readonly String _connString;
        private MySqlConnection _mySqlConnection;
        private DienstregelingDA _dienstregelingDA;
        #endregion

        #region constructor
        public OpgeslagenDA()
        {
            _connString = "server=localhost;user id=root;database=gip2";

            _mySqlConnection = new MySqlConnection(_connString);

            _dienstregelingDA = new DienstregelingDA();
        }
        #endregion

        #region database
        /// <summary>
        /// leest alle opgeslagen routes van 1 enkele gebruiker
        /// </summary>
        /// <param name="gebruikerID">BebruikersID van de gewenste gebruiker</param>
        /// <returns>Lijst van alle opgeslagen routes</returns>
        public List<Route> ReadTable(int gebruikerID)
        {
            List<Route> lijst = new List<Route>();

            String sql = $"select * from tblopgeslagen where `GebruikersID`= {gebruikerID};";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            _mySqlConnection.Open();

            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read() == true)
            {
                int id = (int)(mySqlDataReader["RitID"]);
                Route route = _dienstregelingDA.ReadRoute(id);

                lijst.Add(route);
            }

            _mySqlConnection.Close();

            return lijst;
        }

        /// <summary>
        /// 1 enkele opgeslagen route uitlezen
        /// </summary>
        /// <param name="gebruikerID">id van de gewesnste gebruiker</param>
        /// <param name="ritID">id van de gewenste route</param>
        /// <returns></returns>
        public int ReadOpgeslagenID(int gebruikerID, int ritID)
        {
          
            String sql = $"select `OpgeslagenID` from tblopgeslagen where `GebruikersID`= {gebruikerID} AND `RitID` = {ritID};";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            _mySqlConnection.Open();

            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            int id = -1;

            while (mySqlDataReader.Read() == true)
            {
                id = (int)(mySqlDataReader["OpgeslagenID"]);
            }

            _mySqlConnection.Close();

            return id;
        }

        /// <summary>
        /// nieuwe route opslaan voor een gebruiker
        /// </summary>
        /// <param name="gebID">Id van de gebruiker</param>
        /// <param name="ritID">Id van de route</param>
        public void CreateRecord(int gebID, int ritID)
        {
            //SQL instructie
            String sql = "Insert into tblopgeslagen (`GebruikersID`,`RitID`) " +
                "Values(@GebruikersID, @RitID);";

            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);


            mySqlCommand.Parameters.AddWithValue("@GebruikersID", gebID);
            mySqlCommand.Parameters.AddWithValue("@RitID", ritID);
           

            _mySqlConnection.Open();

            mySqlCommand.ExecuteNonQuery();

            _mySqlConnection.Close();
        }

        /// <summary>
        /// een opgeslagen route verwijderen
        /// </summary>
        /// <param name="id">Id van opgeslagen route</param>
        public void DeleteRecord(int id)
        {
            String sql = $"Delete from tblopgeslagen where (`OpgeslagenID` = @OpgeslagenID);";

            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            mySqlCommand.Parameters.AddWithValue("@OpgeslagenID", id);

            _mySqlConnection.Open();

            mySqlCommand.ExecuteNonQuery();

            _mySqlConnection.Close();
        }
        #endregion
    }
}
