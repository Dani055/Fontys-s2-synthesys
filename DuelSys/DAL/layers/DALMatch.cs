using System;
using System.Collections.Generic;
using BusinessLayer;
using BusinessLayer.interfaces;
using BusinessLayer.models;
using MySql.Data.MySqlClient;

namespace DAL.layers
{
    public class DALMatch : IDALMatch
    {
        private readonly DBSettings dBSettings;

        public DALMatch()
        {
            dBSettings = new DBSettings();
        }

        public bool AddMatches(List<TourneyMatch> matches)
        {
            MySqlConnection conn = new MySqlConnection(dBSettings.GetConString());

            string sql = "INSERT INTO s2synt_tourney_match (player1_id, player2_id, date, tournament_id) VALUES(@player1_id, @player2_id, @date, @tournament_id); ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlTransaction tran = conn.BeginTransaction();
            cmd.Transaction = tran;

            try
            {
                foreach (TourneyMatch m in matches)
                {
                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("@player1_id", m.Player1.Id == 0 ? null : m.Player1.Id);
                    cmd.Parameters.AddWithValue("@player2_id", m.Player2.Id == 0 ? null : m.Player2.Id);
                    cmd.Parameters.AddWithValue("@date", m.DateHeld.ToString(dBSettings.DateTimeFormat));
                    cmd.Parameters.AddWithValue("@tournament_id", m.TournamentId);
                    cmd.ExecuteNonQuery();
                }
                tran.Commit();
                return true;
            }
            catch
            {
                tran.Rollback();
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<TourneyMatch> GetMatches(int tourneyId)
        {
            MySqlConnection conn = new MySqlConnection(dBSettings.GetConString());
            try
            {
                string sql = "SELECT m.id, m.tournament_id, m.date, m.player1_id, " +
                    "p1.first_name as p1Firstname, p1.last_name as p1Lastname, m.player1_points, " +
                    "m.player2_id, p2.first_name as p2Firstname, p2.last_name as p2Lastname, m.player2_points, m.winner_id " +
                    "FROM s2synt_tourney_match as m " +
                    "left join s2synt_user as p1 " +
                    "on m.player1_id = p1.id " +
                    "left join s2synt_user as p2 " +
                    "on m.player2_id = p2.id " +
                    "WHERE m.tournament_id = @tournament_id " +
                    "order by date;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@tournament_id", tourneyId);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                List<TourneyMatch> list = new List<TourneyMatch>();
                while (reader.Read())
                {

                    int Id = reader.GetInt32("Id");
                    int tournamentId = reader.GetInt32("tournament_id");
                    DateTime date = reader.GetDateTime("date");
                
                    int player1Id = string.IsNullOrEmpty(reader["player1_id"].ToString()) ? 0 : int.Parse(reader["player1_id"].ToString());
                    string player1firstname = reader["p1Firstname"].ToString();
                    string player1lastname = reader["p1Lastname"].ToString();
                    Player player1 = new Player()
                    {
                        Id = player1Id,
                        Firstname = player1firstname,
                        Lastname = player1lastname,
                    };
                    int player1points = string.IsNullOrEmpty(reader["player1_points"].ToString()) ? 0 : int.Parse(reader["player1_points"].ToString());

                    int player2Id = string.IsNullOrEmpty(reader["player2_id"].ToString()) ? 0 : int.Parse(reader["player2_id"].ToString());
                    string player2firstname = reader["p2Firstname"].ToString();
                    string player2lastname = reader["p2Lastname"].ToString();
                    Player player2 = new Player()
                    {
                        Id = player2Id,
                        Firstname = player2firstname,
                        Lastname = player2lastname,
                    };
                    int player2points = string.IsNullOrEmpty(reader["player2_points"].ToString()) ? 0 : int.Parse(reader["player2_points"].ToString());

                    int winnerId = string.IsNullOrEmpty(reader["winner_id"].ToString()) ? 0 : int.Parse(reader["winner_id"].ToString()); ;

                    TourneyMatch tm = new TourneyMatch(Id, tournamentId, date, player1, player1points, player2, player2points, winnerId);

                    list.Add(tm);

                }
                reader.Close();
                return list;
            }
            finally
            {
                conn.Close();
            }
        }
        public List<TourneyMatch> GetPlayerMatches(int playerId)
        {
            MySqlConnection conn = new MySqlConnection(dBSettings.GetConString());
            try
            {
                string sql = "SELECT m.id, m.tournament_id, m.date, m.player1_id, " +
                    "p1.first_name as p1Firstname, p1.last_name as p1Lastname, m.player1_points, " +
                    "m.player2_id, p2.first_name as p2Firstname, p2.last_name as p2Lastname, m.player2_points, m.winner_id " +
                    "FROM s2synt_tourney_match as m " +
                    "left join s2synt_user as p1 " +
                    "on m.player1_id = p1.id " +
                    "left join s2synt_user as p2 " +
                    "on m.player2_id = p2.id " +
                    "WHERE m.player1_id = @id OR m.player2_id = @id " +
                    "order by date DESC LIMIT 10;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", playerId);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                List<TourneyMatch> list = new List<TourneyMatch>();
                while (reader.Read())
                {

                    int Id = reader.GetInt32("Id");
                    int tournamentId = reader.GetInt32("tournament_id");
                    DateTime date = reader.GetDateTime("date");

                    int player1Id = string.IsNullOrEmpty(reader["player1_id"].ToString()) ? 0 : int.Parse(reader["player1_id"].ToString());
                    string player1firstname = reader["p1Firstname"].ToString();
                    string player1lastname = reader["p1Lastname"].ToString();
                    Player player1 = new Player()
                    {
                        Id = player1Id,
                        Firstname = player1firstname,
                        Lastname = player1lastname,
                    };
                    int player1points = string.IsNullOrEmpty(reader["player1_points"].ToString()) ? 0 : int.Parse(reader["player1_points"].ToString());

                    int player2Id = string.IsNullOrEmpty(reader["player2_id"].ToString()) ? 0 : int.Parse(reader["player2_id"].ToString());
                    string player2firstname = reader["p2Firstname"].ToString();
                    string player2lastname = reader["p2Lastname"].ToString();
                    Player player2 = new Player()
                    {
                        Id = player2Id,
                        Firstname = player2firstname,
                        Lastname = player2lastname,
                    };
                    int player2points = string.IsNullOrEmpty(reader["player2_points"].ToString()) ? 0 : int.Parse(reader["player2_points"].ToString());
                    int winnerId = string.IsNullOrEmpty(reader["winner_id"].ToString()) ? 0 : int.Parse(reader["winner_id"].ToString()); ;

                    TourneyMatch tm = new TourneyMatch(Id, tournamentId, date, player1, player1points, player2, player2points, winnerId);

                    list.Add(tm);

                }
                reader.Close();
                return list;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool EnterMatchScore(Tournament tourney, TourneyMatch match)
        {
            MySqlConnection conn = new MySqlConnection(dBSettings.GetConString());

            int loserId = 0;
            if (match.Player1Points > match.Player2Points)
            {
                loserId= match.Player2.Id;
            }
            else
            {
                loserId = match.Player1.Id;
            }

            string sql = "UPDATE s2synt_tourney_match SET player1_points = @p1points, player2_points = @p2points, winner_id = @winner_id WHERE id = @id;" +
                "UPDATE s2synt_tourney_standings SET wins = wins + 1 WHERE tournament_id = @tournament_id AND player_id = @winner_id;" +
                "UPDATE s2synt_tourney_standings SET losses = losses + 1 WHERE tournament_id = @tournament_id AND player_id = @loser_id;" +
                "UPDATE s2synt_user SET won_games = won_games + 1 WHERE id = @winner_id;" +
                "UPDATE s2synt_user SET lost_games = lost_games + 1 WHERE id = @loser_id;";

            if (tourney.System.SystemName == "Single-elimination")
            {
                sql += "update s2synt_tourney_match set player1_id  = if(player1_id is null, @winner_id, player1_id), player2_id = if(player2_id is null and player1_id != @winner_id, @winner_id, player2_id) where id in" +
                    "(SELECT id FROM (SELECT id FROM s2synt_tourney_match where (player1_id is NULL or player2_id is NULL) and tournament_id = @tournament_id ORDER BY date LIMIT 1) as t);";
            }

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlTransaction tran = conn.BeginTransaction();
            cmd.Transaction = tran;

            try
            {
                cmd.Parameters.AddWithValue("@id", match.Id);
                cmd.Parameters.AddWithValue("@tournament_id", match.TournamentId);
                cmd.Parameters.AddWithValue("@p1points", match.Player1Points);
                cmd.Parameters.AddWithValue("@p2points", match.Player2Points);
                cmd.Parameters.AddWithValue("@winner_id", match.WinnerId);
                cmd.Parameters.AddWithValue("@loser_id", loserId);

                cmd.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch
            {
                tran.Rollback();
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
