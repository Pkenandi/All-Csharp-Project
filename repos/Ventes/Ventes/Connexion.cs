using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace vente
{
    class Connexion
    {
        public static MySqlConnection Cnn = new MySqlConnection("database = ventes; server = localhost; userID = root; pwd = '' ");

        public static void Connect()
        {
            Cnn.Open();

        }

        public static void Disconnect()
        {
            Cnn.Close();
        }
        

    }
}
