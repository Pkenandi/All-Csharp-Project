using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Examen_3
{
    class DBconnection
    {
        public static MySqlConnection Cnn = new MySqlConnection(@"Server=127.0.0.1;Port = 3308;UID=root;database=examen_3; Pwd = '1234' ");

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
