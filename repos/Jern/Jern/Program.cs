using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Jern
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection cnn = DBConnection.GetConnection();

            PRL.AfficherBulletin(10);
        }
    }
}
