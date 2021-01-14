using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            //Personne P = new Personne();
            ////Tableau.Saisie();

            //Operation.Saisir(P);
            //Operation.Affichage();

            Connexion.ConnectTo();


            //Operations.AjoutPersonne();
            //Operations.AjoutAnimal();
            Operations.ShowAllAnimals();
            Console.WriteLine("\n");
            Operations.ShowAllPersons();
            Console.WriteLine("\n");
            Operations.UpdateAnimal();

        }
    }
}
