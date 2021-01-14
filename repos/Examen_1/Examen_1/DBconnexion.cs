using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Examen_1
{
    class DBconnexion
    {

        public static MySqlConnection Link = new MySqlConnection(@"Server=127.0.0.1;Port = 3306;UID=root;database=gestionnote; Pwd = '' ");
        
        public static void Connect()
        {
            Link.Open();
        }

        public static void DisConnect()
        {
            Link.Close();
        }

    }
}
