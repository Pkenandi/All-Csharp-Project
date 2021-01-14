using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Accdb
{
    class Program
    {
        public static OleDbConnection connexion;
        public static OleDbCommand cmd;

        static void Main(string[] args)
        {


            //Connection();
            //Add();

            Connexion.Connection();
            Operation.Update();

            //Connection();
            //Drop();
            Connexion.Connection();
            Console.WriteLine(" Il y a " + Operation.Display() + " Article(s) ");

        }
    }
}
