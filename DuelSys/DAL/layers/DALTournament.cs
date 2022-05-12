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
                string sql = "INSERT INTO s2synt_tournament (name, sport_id, description, start_date, end_date, min_players, max_players, location, system_id, hasStarted) VALUES(@name, @sport_id, @description, @start_date, @end_date, @min_players, @max_players, @location, @system_id, @hasStarted); ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", tourney.Name);
                cmd.Parameters.AddWithValue("@sport_id", Array.IndexOf(DBEnums.Sports, tourney.SportName));
                cmd.Parameters.AddWithValue("@description", tourney.Description);
                cmd.Parameters.AddWithValue("@start_date", tourney.StartDate.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@end_date", tourney.EndDate.ToString("yyyy-MM-dd"));
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

        public Tournament GetTournamentById(int id)
        {
            MySqlConnection conn = new MySqlConnection(dBSettings.GetConString());
            try
            {
                string sql = "SELECT * FROM s2synt_tournament WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    int Id = reader.GetInt32("id");
                    string name = reader.GetString("name");
                    string sport = DBEnums.Sports[reader.GetInt32("sport_id")];
                    string description = reader.GetString("description");
                    DateTime startdate = DateTime.Parse(reader.GetString("start_date"));
                    DateTime enddate = DateTime.Parse(reader.GetString("end_date"));
                    int minplayers = reader.GetInt32("min_players");
                    int maxplayers = reader.GetInt32("max_players");
                    string location = reader.GetString("location");
                    string system = DBEnums.TournamentSystems[reader.GetInt16("system_id")];
                    bool hasstarted = reader.GetBoolean("hasStarted");

                    Tournament tourney = new Tournament(Id,name, sport, description, startdate, enddate, minplayers, maxplayers, location, system, hasstarted);

                    reader.Close();
                    return tourney;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Tournament> GetPendingTournaments()
        {
            MySqlConnection conn = new MySqlConnection(dBSettings.GetConString());
            try
            {
                string sql = "SELECT * FROM s2synt_tournament where hasStarted = FALSE";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                List<Tournament> tourneys = new List<Tournament>();

                while (reader.Read())
                {
                    int Id = reader.GetInt32("id");
                    string name = reader.GetString("name");
                    string sport = DBEnums.Sports[reader.GetInt32("sport_id")];
                    string description = reader.GetString("description");
                    DateTime startdate = DateTime.Parse(reader.GetString("start_date"));
                    DateTime enddate = DateTime.Parse(reader.GetString("end_date"));
                    int minplayers = reader.GetInt32("min_players");
                    int maxplayers = reader.GetInt32("max_players");
                    string location = reader.GetString("location");
                    string system = DBEnums.TournamentSystems[reader.GetInt16("system_id")];
                    bool hasstarted = reader.GetBoolean("hasStarted");

                    Tournament tourney = new Tournament(Id,name, sport, description, startdate, enddate, minplayers, maxplayers, location, system, hasstarted);

                    tourneys.Add(tourney);
                }
                    
                reader.Close();
                return tourneys;
            }
            finally
            {
                conn.Close();
            }
        }
        public List<Tournament> GetOngoingTournaments()
        {
            MySqlConnection conn = new MySqlConnection(dBSettings.GetConString());
            try
            {
                string now = Utils.GetSystemDate.Date.ToString("yyyy-MM-dd");

                string sql = "SELECT * FROM s2synt_tournament where start_date <= @now and end_date >= @now";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();
                cmd.Parameters.AddWithValue("@now", now);

                MySqlDataReader reader = cmd.ExecuteReader();
                List<Tournament> tourneys = new List<Tournament>();

                while (reader.Read())
                {
                    int Id = reader.GetInt32("id");
                    string name = reader.GetString("name");
                    string sport = DBEnums.Sports[reader.GetInt32("sport_id")];
                    string description = reader.GetString("description");
                    DateTime startdate = DateTime.Parse(reader.GetString("start_date"));
                    DateTime enddate = DateTime.Parse(reader.GetString("end_date"));
                    int minplayers = reader.GetInt32("min_players");
                    int maxplayers = reader.GetInt32("max_players");
                    string location = reader.GetString("location");
                    string system = DBEnums.TournamentSystems[reader.GetInt16("system_id")];
                    bool hasstarted = reader.GetBoolean("hasStarted");

                    Tournament tourney = new Tournament(Id, name, sport, description, startdate, enddate, minplayers, maxplayers, location, system, hasstarted);

                    tourneys.Add(tourney);
                }

                reader.Close();
                return tourneys;
            }
            finally
            {
                conn.Close();
            }
        }
        public List<Tournament> GetEndedTournaments()
        {
            MySqlConnection conn = new MySqlConnection(dBSettings.GetConString());
            try
            {
                string now = Utils.GetSystemDate.Date.ToString("yyyy-MM-dd");

                string sql = "SELECT * FROM s2synt_tournament where end_date < @now";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();
                cmd.Parameters.AddWithValue("@now", now);

                MySqlDataReader reader = cmd.ExecuteReader();
                List<Tournament> tourneys = new List<Tournament>();

                while (reader.Read())
                {
                    int Id = reader.GetInt32("id");
                    string name = reader.GetString("name");
                    string sport = DBEnums.Sports[reader.GetInt32("sport_id")];
                    string description = reader.GetString("description");
                    DateTime startdate = DateTime.Parse(reader.GetString("start_date"));
                    DateTime enddate = DateTime.Parse(reader.GetString("end_date"));
                    int minplayers = reader.GetInt32("min_players");
                    int maxplayers = reader.GetInt32("max_players");
                    string location = reader.GetString("location");
                    string system = DBEnums.TournamentSystems[reader.GetInt16("system_id")];
                    bool hasstarted = reader.GetBoolean("hasStarted");

                    Tournament tourney = new Tournament(Id, name, sport, description, startdate, enddate, minplayers, maxplayers, location, system, hasstarted);

                    tourneys.Add(tourney);
                }

                reader.Close();
                return tourneys;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool RegisterPlayerForTournament(int tourneyId, int playerId)
        {
            MySqlConnection conn = new MySqlConnection(dBSettings.GetConString());
            try
            {
                string sql = "INSERT INTO s2synt_tourney_standings (tournament_id, player_id) VALUES(@tournament_id, @player_id); ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@tournament_id", tourneyId);
                cmd.Parameters.AddWithValue("@player_id", playerId);
                
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return true;
            }
            finally
            {
                conn.Close();
            }
        }
        public TourneyStanding GetTournamentStanding(int tourneyId, int playerId)
        {
            MySqlConnection conn = new MySqlConnection(dBSettings.GetConString());
            try
            {
                string sql = "SELECT ts.Id, ts.tournament_id, ts.player_id, ts.wins, ts.losses, ts.status, ts.place, u.first_name, u.last_name " +
                    "FROM s2synt_tourney_standings as ts " +
                    "inner join s2synt_user as u " +
                    "on ts.player_id = u.id WHERE tournament_id = @tournament_id and player_id = @player_id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@tournament_id", tourneyId);
                cmd.Parameters.AddWithValue("@player_id", playerId);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    int Id = reader.GetInt32("Id");
                    int tournamentId = reader.GetInt32("tournament_id");
                    int playerid = reader.GetInt32("player_id");
                    int wins = reader.GetInt32("wins");
                    int losses = reader.GetInt32("losses");
                    string status = reader.GetString("status");
                    int place = int.Parse(reader["wins"].ToString());
                    string playerfirstname = reader.GetString("first_name");
                    string playerlastname = reader.GetString("last_name");

                    TourneyStanding ts = new TourneyStanding(Id, tournamentId, playerid, playerfirstname, playerlastname, wins, losses, status, place);

                    reader.Close();
                    return ts;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
