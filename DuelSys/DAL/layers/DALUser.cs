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
    public class DALUser : IDALUser
    {
        private readonly DBSettings dBSettings;

        public DALUser()
        {
            dBSettings = new DBSettings();
        }
        public User Login(string username)
        {
            MySqlConnection conn = new MySqlConnection(dBSettings.GetConString());
            try
            {
                string sql = "SELECT * FROM s2synt_user WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    int id = reader.GetInt32("id");
                    string uname = reader.GetString("username");
                    string pwd = reader.GetString("password");
                    string email = reader.GetString("email");
                    string address = reader["address"].ToString();
                    string firstname = reader.GetString("first_name");
                    string lastname = reader.GetString("last_name");
                    string role = DBEnums.Roles[reader.GetInt16("role_id")];
                    User user = null;
                    if (role == "Staff")
                    {
                        double salary = Double.Parse(reader["salary"].ToString());
                        user = new Staff(id, uname, pwd, email,address, firstname, lastname, role, salary);
                        
                    }
                    else if (role == "Player")
                    {
                        int wongames = int.Parse(reader["won_games"].ToString());
                        int lostgames = int.Parse(reader["lost_games"].ToString());
                        user = new Player(id, uname, pwd, email,address, firstname, lastname, role, wongames, lostgames);
                    }

                    reader.Close();
                    return user;
                }
                else
                {
                    reader.Close();
                    throw new Exception("Wrong username or password!");
                }
            }
            finally
            {
                conn.Close();
            }
        }

        public bool RegisterStaff(Staff staff)
        {
            MySqlConnection conn = new MySqlConnection(dBSettings.GetConString());
            try
            {
                string sql = "INSERT INTO s2synt_user (username, password, email, address, first_name, last_name, role_id, won_games, lost_games, salary) VALUES(@username, @password, @email, @address, @first_name, @last_name, @role_id, @won_games, @lost_games, @salary); ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@username", staff.Username);
                cmd.Parameters.AddWithValue("@password", staff.Password);
                cmd.Parameters.AddWithValue("@email", staff.Email);
                cmd.Parameters.AddWithValue("@address", staff.Address);
                cmd.Parameters.AddWithValue("@first_name", staff.Firstname);
                cmd.Parameters.AddWithValue("@last_name", staff.Lastname);
                cmd.Parameters.AddWithValue("@role_id", Array.IndexOf(DBEnums.Roles, staff.Role.RoleName));
                cmd.Parameters.AddWithValue("@won_games", null);
                cmd.Parameters.AddWithValue("@lost_games", null);
                cmd.Parameters.AddWithValue("@salary", staff.Salary);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return true;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool RegisterPlayer(Player player)
        {
            MySqlConnection conn = new MySqlConnection(dBSettings.GetConString());
            try
            {
                string sql = "INSERT INTO s2synt_user (username, password, email, address, first_name, last_name, role_id, won_games, lost_games, salary) VALUES(@username, @password, @email, @address, @first_name, @last_name, @role_id, @won_games, @lost_games, @salary); ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@username", player.Username);
                cmd.Parameters.AddWithValue("@password", player.Password);
                cmd.Parameters.AddWithValue("@email", player.Email);
                cmd.Parameters.AddWithValue("@address", player.Address);
                cmd.Parameters.AddWithValue("@first_name", player.Firstname);
                cmd.Parameters.AddWithValue("@last_name", player.Lastname);
                cmd.Parameters.AddWithValue("@role_id", Array.IndexOf(DBEnums.Roles, player.Role.RoleName));
                cmd.Parameters.AddWithValue("@won_games", 0);
                cmd.Parameters.AddWithValue("@lost_games", 0);
                cmd.Parameters.AddWithValue("@salary", null);
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
