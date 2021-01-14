using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Examen_2
{
    class Connexion
    {
        public static MySqlConnection Cnn = new MySqlConnection(@"Server=127.0.0.1;Port = 3308;UID=root;database=examen_2; Pwd = '1234' ");

        public static void Connect()
        {
            Cnn.Open();

        }

        public static void DisConnect()
        {
            Cnn.Close();
        }
    }
}
