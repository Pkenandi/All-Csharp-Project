using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin
{
    class Program
    {
        static void Main(string[] args)
        {
            Magazin Mag = new Magazin();
            Fournisseur F = new Fournisseur();
            Article Art = new Article();

            Connexion.ConnectTo();

            //Operations.AjoutArticle(Art);
            //Operations.AjoutFournisseur(F);
            //Operations.AjoutMagazin(Mag);

            /* ----------------------------------*/

            Operations.ArtPvX();
            Console.WriteLine("\n");
            Operations.LocMag();

            Console.WriteLine("\n");
            Operations.ArtCoulPoidsX(Art);
            Console.WriteLine("\n");
            Operations.PoidsPaX();
            Console.WriteLine("\n");
            Operations.PaSupX();
            Console.WriteLine("\n");
            Operations.MargeB();
            Console.WriteLine("\n");
            Operations.MoyMaxMin();
            Console.WriteLine("\n");
            Operations.DiffCouleurArt();
            Console.WriteLine("\n");
            Operations.MoyPV();
            Console.WriteLine("\n");
            Operations.SomPV();
            Console.WriteLine("\n");
            Operations.FrsCouleurX();
            Console.WriteLine("\n");
            Operations.MinPvCoulX();
            Console.WriteLine("\n");
            Operations.GerantLocX();
            Console.WriteLine("\n");
            Operations.ArtPvSupX();
            Console.WriteLine("\n");
            Operations.MagLocX();
            Console.WriteLine("\n");
            Operations.ArtPrixVCher();

        }
    }
}
