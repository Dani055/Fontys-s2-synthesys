using BusinessLayer;
using BusinessLayer.interfaces;
using BusinessLayer.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.layers
{
    public class DALTournament : IDALTournament
    {
        private readonly DBSettings dBSettings;

        public DALTournament()
        {
            dBSettings = new DBSettings();
        }
        public bool CreateTournament(Tournament tourney)
        {
            MySqlConnection conn = new MySqlConnection(dBSettings.GetConString());
            try
            {
                string sql = "INSERT INTO s2synt_tournament (sport_id, description, start_date, end_date, min_players, max_players, location, system_id, hasStarted) VALUES(@sport_id, @description, @start_date, @end_date, @min_players, @max_players, @location, @system_id, @hasStarted); ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@sport_id", Array.IndexOf(DBEnums.Sports, tourney.SportName));
                cmd.Parameters.AddWithValue("@description", tourney.Description);
                cmd.Parameters.AddWithValue("@start_date", tourney.StartDate.ToString(dBSettings.DateTimeFormat));
                cmd.Parameters.AddWithValue("@end_date", tourney.EndDate.ToString(dBSettings.DateTimeFormat));
                cmd.Parameters.AddWithValue("@min_players", tourney.MinPlayers);
                cmd.Parameters.AddWithValue("@max_players", tourney.MaxPlayers);
                cmd.Parameters.AddWithValue("@location", tourney.Location);
                cmd.Parameters.AddWithValue("@system_id", Array.IndexOf(DBEnums.TournamentSystems, tourney.SystemName));
                cmd.Parameters.AddWithValue("@hasStarted", false);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return true;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
