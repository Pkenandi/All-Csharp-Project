using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Jern
{
    class DBConnection
    {
        public static MySqlConnection GetConnection()
        {
            MySqlConnection cnn = new MySqlConnection(@"server=localhost;port=3308;userid=root;pwd='1234' ;database=examen_1");

            return cnn;
        }
    }
}
