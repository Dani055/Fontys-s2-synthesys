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

                    cmd.Parameters.AddWithValue("@player1_id", m.Player1id);
                    cmd.Parameters.AddWithValue("@player2_id", m.Player2id);
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
    }
}
