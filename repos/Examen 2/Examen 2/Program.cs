using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Examen_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Connexion.Connect();
            Console.WriteLine(" Your connect !! ");

            //Boolean rep = revision.Exit(4);

            //if (rep)
            //    Console.WriteLine(" L'id existe deja !");
            //else
            //    Console.WriteLine(" L'id n'existe pas encore !");

            //revision.add(4, "Anim");
            //int rep = revision.GetQuantity(2, 3);

            //revision.UpdateQuantity_1(1, 1, 25);
            //revision.ConstrainedUpdateQuantity(2, 1, -60);
            revision.Transfert(1, 2, 2, 1);

            Connexion.DisConnect();
           

        }
    }
}
