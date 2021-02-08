using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;

namespace ConfPoste_ASPCore.Models
{
    public static class DatabaseHelper
    {
        private static readonly MySqlConnectionStringBuilder connectionBuilder = new MySqlConnectionStringBuilder
        {
            Server = "localhost",
            Port = 3307,
            UserID = "brendan",
            Password = "epsi",
            Database = "test"
        };

        public static string GetHelloWorld()
        {
            try
            {
                string hello = null;

                using (MySqlConnection connection = new MySqlConnection(connectionBuilder.ToString()))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM hello WHERE Id = 1;", connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                                hello = reader.GetString("Description");
                        }
                    }
                }

                return hello;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw e;
            }
        }
    }
}
