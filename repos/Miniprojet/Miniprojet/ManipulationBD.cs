using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Miniprojet
{
    class ManipulationBD
    {
        public static string StrCon = " Server = localhost; Database = stl; Uid = root; Pwd = ;";
        public static MySqlConnection Cnn = new MySqlConnection(StrCon);

        public static void ConnectionDataBase()
        {
            Cnn.Open();
        }

        public static void DecoonectionDataBase()
        {
            Cnn.Close();
        }
    }
}
