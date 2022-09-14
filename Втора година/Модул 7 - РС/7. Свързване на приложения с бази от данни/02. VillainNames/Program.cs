using System;
using MySql.Data.MySqlClient;

namespace _02._VillainNames
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;pwd=sqlPass;database=minionsdb");

            connection.Open();
            using (connection)
            {
                MySqlCommand command = new MySqlCommand("SELECT name, COUNT(minionid) FROM villains v JOIN minionsvillains mv ON v.id = mv.villainid GROUP BY name", connection);

                MySqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        string name = (string)reader["name"];
                        long count = (long)reader["COUNT(minionid)"];

                        Console.WriteLine($"{name} - {count}");
                    }
                }
            }
        }
    }
}
