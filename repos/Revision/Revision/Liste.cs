using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    class Personne
    {
        public int ID { get; set; }
        public string nom { set; get; }
        public string prenom { set; get; }
        public int age { set; get; }

        public Personne()
        {

        }


    }

    class Animal
    {
        public int Code { set; get; }
        public string Nom { set; get; }
        public string Race { set; get; }
        public int IdP { set; get; }


    }

    class Operation
    {
        static List<Personne> P = new List<Personne>();

        public static void Saisir(Personne Pers)
        {
            

            Console.Write(" Nom : ");
            Pers.nom = Console.ReadLine();
            Console.Write(" Prenom : ");
            Pers.prenom = Console.ReadLine();
            Console.Write(" Age : ");
            Pers.age = int.Parse(Console.ReadLine());

            P.Add(Pers);
            
        }

        public static void Affichage()
        {
            foreach( Personne p in P )
            {
                Console.Write(" Nom : " + p.nom + " Prenom : " + p.prenom + " Age : " + p.age );
            }
        }
    }

}
