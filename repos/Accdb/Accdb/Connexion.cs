using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Accdb
{
    class Connexion
    {
       
        public static void Connection()
        {
            string AccessLink = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\kevin\Documents\vente.accdb;";

            Program.connexion = new OleDbConnection(AccessLink);

            Program.connexion.Open();

            Console.WriteLine(" Connexion reussie !! ");

        }

    }

}
