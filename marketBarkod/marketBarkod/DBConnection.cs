using MySql.Data;
using MySql.Data.MySqlClient;
using System;

namespace marketBarkod
{
    public class DBConnection
    {
        private DBConnection()
        {
        }
        /**
         * listeleme örnek
         */
        public void listData() {
            string sql = "select * from market.product ";
            MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=41234;database=market;");
            MySqlCommand cmd = new MySqlCommand(sql, con);

            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int stock = (int)reader["stock"];
                int price = (int)reader["price"];
            }
        }
       
    }
}