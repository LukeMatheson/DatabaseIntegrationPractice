using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Server=.\\SQLEXPRESS;Database=NFLTeams;Integrated Security=true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TeamInformation", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Team Name: {0}", reader.GetString(1));
            }

            reader.Close();
            conn.Close();

            if (Debugger.IsAttached)
            {
                Console.ReadLine();
            }

        }
    }
}
