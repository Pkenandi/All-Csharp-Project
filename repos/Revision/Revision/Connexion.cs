using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Revision
{
    class Connexion
    {
        public static MySqlConnection Connect = new MySqlConnection(" Database = revision; server = localhost; UserID=root; pwd ='' ");
        

        public static void ConnectTo()
        {
            Connect.Open();
            Console.WriteLine("    Connected   ");

        }
    }
}
