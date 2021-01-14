using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Examen_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Etudiant Et = new Etudiant();
            DBconnexion.Connect();

            Console.WriteLine(" You are connected !! ");

   

            //Console.WriteLine("\n");
            //PRL.AfficherEnteteBulletin(Num);

            //Console.WriteLine("\n");
            //PRL.AfficherDetailsNotesBulletin(Num);

            //Console.WriteLine("\n");
            //PRL.AfficherMoyenneGenerale(Num);

            //Console.WriteLine();
            //PRL.AfficherBulletin(Num);

            DAL.Afficher();

            DBconnexion.DisConnect();
            Console.ReadKey();
        }
    }
}
