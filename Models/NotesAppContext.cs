using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace NotesApp.Models
{
    public class NotesAppContext
    {
        public string ConnectionString { get; set; }
        public NotesAppContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<UserModel> GetAllUsers()
        {
            List<UserModel> list = new List<UserModel>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from users", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new UserModel()
                        {
                            id = Convert.ToInt32(reader["id"]),
                            full_name = reader["full_name"].ToString(),
                            email = reader["email"].ToString(),
                            username = reader["username"].ToString(),   
                            password = reader["password"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public void saveNewUser(String name, DateTime dob, String email, String username, String password) {
            using (MySqlConnection conn = GetConnection()) {
                conn.Open();
                new MySqlCommand("insert into users (full_name, dob, email, username, password) values (" + name + ", " + dob + ", " + email + ", " + username + ", " + password + ")", conn);
            }
        }
    }
}
