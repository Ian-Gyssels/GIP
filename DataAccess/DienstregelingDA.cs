using System;
using System.Collections.Generic;
using Business;
using MySql.Data.MySqlClient;


namespace DataAccess
{
    public class DienstregelingDA
    {
        #region velden
        private readonly String _connString;
        private MySqlConnection _mySqlConnection;
        #endregion

        #region construction
        public DienstregelingDA()
        {
            _connString = "server=localhost;user id=root;database=gip2";

            _mySqlConnection = new MySqlConnection(_connString);
        }
        #endregion

        #region database
        /// <summary>
        /// haalt alle de routes uit van een bepaald schema
        /// </summary>
        /// <param name="schema">false: week | true: weekend</param>
        /// <returns>Lijst met routes</returns>
        public List<Route> ReadTable(bool schema)
        {
            int schemaLetter = SchemaInstellen(schema);

            List<Route> lijst = new List<Route>();

            String sql = $"select * from tbldienstregeling where `Schema`={schemaLetter} order by `VertrekUur`;";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            _mySqlConnection.Open();

            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read() == true)
            {
                Route route = new Route((int)(mySqlDataReader["RitId"]),
                                                                (int)(mySqlDataReader["VertrekUur"]),
                                                                (int)(mySqlDataReader["VertrekMinuut"]),
                                                                mySqlDataReader["AankomstStation"].ToString(),
                                                                (int)mySqlDataReader["AankomstUur"],
                                                                (int)(mySqlDataReader["AankomstMinuut"]),
                                                                (int)(mySqlDataReader["Afstand"]),
                                                                (int)(mySqlDataReader["Schema"]));

                lijst.Add(route);
            }

            _mySqlConnection.Close();

            return lijst;
        }

        public List<Route> ReadAllesTable()
        {

            List<Route> lijst = new List<Route>();

            String sql = $"select * from tbldienstregeling order by `VertrekUur`;";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            _mySqlConnection.Open();

            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read() == true)
            {
                Route route = new Route((int)(mySqlDataReader["RitId"]),
                                                                (int)(mySqlDataReader["VertrekUur"]),
                                                                (int)(mySqlDataReader["VertrekMinuut"]),
                                                                mySqlDataReader["AankomstStation"].ToString(),
                                                                (int)mySqlDataReader["AankomstUur"],
                                                                (int)(mySqlDataReader["AankomstMinuut"]),
                                                                (int)(mySqlDataReader["Afstand"]),
                                                                (int)(mySqlDataReader["Schema"]));

                lijst.Add(route);
            }

            _mySqlConnection.Close();

            return lijst;
        }

        /// <summary>
        /// haalt 1 bepaalde route uit de database
        /// </summary>
        /// <param name="ID">Id van de route</param>
        /// <returns>Route van meegegeven ID</returns>
        public Route ReadRoute(int ID)
        {
            
            String sql = $"select * from tbldienstregeling where `RitId`={ID} order by `VertrekUur`;";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            _mySqlConnection.Open();

            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            Route route = null;
            while (mySqlDataReader.Read() == true)
            {
                route = new Route((int)(mySqlDataReader["RitId"]),
                                                                (int)(mySqlDataReader["VertrekUur"]),
                                                                (int)(mySqlDataReader["VertrekMinuut"]),
                                                                mySqlDataReader["AankomstStation"].ToString(),
                                                                (int)mySqlDataReader["AankomstUur"],
                                                                (int)(mySqlDataReader["AankomstMinuut"]),
                                                                (int)(mySqlDataReader["Afstand"]),
                                                                (int)(mySqlDataReader["Schema"]));

            }

            _mySqlConnection.Close();

            return route;
        }

        /// <summary>
        /// haalt de routes af via meegegeven sql code
        /// </summary>
        /// <param name="sql">sql opdracht et filter</param>
        /// <returns>Lijst met routes</returns>
        public List<Route> FilterTable(String sql)
        {
            List<Route> lijst = new List<Route>();

            
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            _mySqlConnection.Open();

            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read() == true)
            {
                Route route = new Route((int)(mySqlDataReader["RitId"]),
                                                                (int)(mySqlDataReader["VertrekUur"]),
                                                                (int)(mySqlDataReader["VertrekMinuut"]),
                                                                mySqlDataReader["AankomstStation"].ToString(),
                                                                (int)mySqlDataReader["AankomstUur"],
                                                                (int)(mySqlDataReader["AankomstMinuut"]),
                                                                (int)(mySqlDataReader["Afstand"]),
                                                                (int)(mySqlDataReader["Schema"]));

                lijst.Add(route);
            }

            _mySqlConnection.Close();

            return lijst;
        }

        /// <summary>
        /// past de gegevens aan van 1 route in de databasse
        /// </summary>
        /// <param name="route">Route met aangepaste gegevens</param>
        public void UpdateRecord(Route route)
        {
            String sql = "Update tbldienstregeling set `VertrekUur` = @VertrekUur," +
                        " `VertrekMinuut` = @VertrekMinuut," +
                        " `AankomstStation` = @AankomstStation," +
                        " `AankomstUur` = @AankomstUur," +
                        " `AankomstMinuut` = @AankomstMinuut," +
                        " `Afstand` = @Afstand," +
                        " `Schema` = @Schema" +
                        " where (RitId = @RitId)";

            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            mySqlCommand.Parameters.AddWithValue("@VertrekUur", route.VertrekUur);
            mySqlCommand.Parameters.AddWithValue("@VertrekMinuut", route.VertrekMinuut);
            mySqlCommand.Parameters.AddWithValue("@AankomstStation", route.AankomstStation);
            mySqlCommand.Parameters.AddWithValue("@AankomstUur", route.AankomstUur);
            mySqlCommand.Parameters.AddWithValue("@AankomstMinuut", route.AankomstMinuut);
            mySqlCommand.Parameters.AddWithValue("@Afstand", route.Afstand);
            mySqlCommand.Parameters.AddWithValue("@Schema", route.EnkelWeek);
            mySqlCommand.Parameters.AddWithValue("@RitId", route.RitId);

            _mySqlConnection.Open();

            mySqlCommand.ExecuteNonQuery();

            _mySqlConnection.Close();
        }

        /// <summary>
        /// plaatst een nieuwe route in de datebase
        /// </summary>
        /// <param name="route">Nieuwe route</param>
        public void CreateRecord(Route route)
        {
            //SQL instructie
            String sql = "Insert into tbldienstregeling (`VertrekUur`,`VertrekMinuut`,`AankomstStation`,`AankomstUur`,`AankomstMinuut`,`Afstand`,`Schema`) " +
                "Values(@VertrekUur, @VertrekMinuut, @AankomstStation, @AankomstUur, @AankomstMinuut, @Afstand, @Schema);";

            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

           
            mySqlCommand.Parameters.AddWithValue("@VertrekUur", route.VertrekUur);
            mySqlCommand.Parameters.AddWithValue("@VertrekMinuut", route.VertrekMinuut);
            mySqlCommand.Parameters.AddWithValue("@AankomstStation", route.AankomstStation);
            mySqlCommand.Parameters.AddWithValue("@AankomstUur", route.AankomstUur);
            mySqlCommand.Parameters.AddWithValue("@AankomstMinuut", route.AankomstMinuut);
            mySqlCommand.Parameters.AddWithValue("@Afstand", route.Afstand);
            mySqlCommand.Parameters.AddWithValue("@Schema", route.EnkelWeek);

            _mySqlConnection.Open();

            mySqlCommand.ExecuteNonQuery();

            _mySqlConnection.Close();
        }

        /// <summary>
        /// verwijderd een route in de database met behulp van een id
        /// </summary>
        /// <param name="id">id van de te verwijderen route</param>
        public void DeleteRecord(int id)
        {
            String sql = "Delete from tbldienstregeling where (RitId = @RitId);";

            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            mySqlCommand.Parameters.AddWithValue("@RitId", id);

             _mySqlConnection.Open();

             mySqlCommand.ExecuteNonQuery();

            _mySqlConnection.Close();
           
        }

        /// <summary>
        /// toont een lijst met alle namen van de stations in de database
        /// </summary>
        /// <returns>lijst met alle namen van de stations in de database</returns>
        public List<String> ReadUniekeStations()
        {

            List<String> lijst = new List<String>();

            String sql = $"select distinct `AankomstStation` from tbldienstregeling order by `AankomstStation`;";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            _mySqlConnection.Open();

            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read() == true)
            {
                String station = mySqlDataReader["AankomstStation"].ToString();
                                                                

                lijst.Add(station);
            }

            _mySqlConnection.Close();

            return lijst;
        }

        /// <summary>
        /// haalt de afstand af van een bepaald station in de database
        /// </summary>
        /// <param name="station">station waarvan je de afstand wil</param>
        /// <returns>Afstand in KM</returns>
        public int GetStationAfstand( String station)
        {

            String sql = $"select distinct `AankomstStation`, `Afstand` from tbldienstregeling where `AankomstStation` = '{station}' order by `AankomstStation`;";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, _mySqlConnection);

            _mySqlConnection.Open();

            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            int afstand = 0;

            while (mySqlDataReader.Read() == true)
            {
                afstand = (int)mySqlDataReader["Afstand"];

            }

            _mySqlConnection.Close();

            return afstand;
        }
        #endregion

        /// <summary>
        /// veranderd de boolean waarde in een int voor sql code
        /// </summary>
        /// <param name="schema">false: week | true: weekend</param>
        /// <returns>1: week | 2: weekend</returns>
        public int SchemaInstellen(bool schema)
        {
            if (schema)
            {
                return 0;
            } else
            {
                return 1;
            }
            
        }
    }
}

