using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Examen
{
    class Connexion
    {
        public static MySqlConnection Connect()
        {
            MySqlConnection Cnn = new MySqlConnection(" Database = examen_1; server = localhost; UserID = root; Pwd = '' ");

            Cnn.Open();

            return Cnn;
        }
    }
}
