using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Personne
    {
        string Nom;
        string Prenom;
        public Date Datnaiss;

        public Personne()
        {
            Datnaiss = new Date();
        }

        public Personne(string N, string P, Date dat)
        {
            Nom = N;
            Prenom = P;
            Datnaiss = new Date(dat.Jour, dat.Mois, dat.Annee);

        }

        public virtual void Saisir()
        {
            Console.Write(" Nom : ");
            Nom = Console.ReadLine();
            Console.Write(" Prenom : ");
            Prenom = Console.ReadLine();
            Console.WriteLine("\n\t Date de naissance \n");
            Datnaiss.Saisir();

        }

        public override string ToString()
        {
            return " " + Nom + " " + Prenom + " Né le " + Datnaiss;
        }

        public virtual void Afficher()
        {
            Console.WriteLine();
            Console.Write(" " + Nom + " " + Prenom + " Né le ");
            Datnaiss.Afficher();

        }

    }
}
