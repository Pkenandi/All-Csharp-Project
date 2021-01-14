using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Magazin
{
    class Connexion
    {
        public static MySqlConnection Connect = new MySqlConnection("database = magazin; server = localhost; userID = root; pwd = '' ");

        public static void ConnectTo()
        {
            Connect.Open();
            Console.WriteLine("  -- Connected  -- ");

        }

        public static void DisconnectTo()
        {
            Connect.Close();
            Console.WriteLine("  -- Disconnected  -- ");
        }
    }
}
