using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace vente
{

    class Program
    {

        static void Main(string[] args)
        {
            

            Connexion.Connect();

            Console.WriteLine(" ---  Connected ---- ");

            Operation.AjoutClient();
            //Operation.AjoutProduit();
            //Operation.AjoutCommande();
            //Operation.AjoutPC();

                                    //****  Application 1 ****

            //int nbr = Operation.Count();
            //int nbr1 = Operation.NombreCommande();
          

            //Console.WriteLine(" Il y a " + nbr + " Client dans la base de données ");
            //Operation.SUM();
            //Operation.Moy();
            //Operation.MinMax();
            //Operation.Date();
            //Console.WriteLine(" <" + nbr1 + "> Clients ont passés les commandes ");
            //Operation.SumQtes();
            //Operation.NbrArticleCommande();
            ////Operation.DeleteClient();
            //Operation.Update();

        }
    }
}
