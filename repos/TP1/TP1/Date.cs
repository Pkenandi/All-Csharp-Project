using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Date
    {
        public int Jour { get; set; }
        public int Mois { get; set; }
        public int Annee { get; set; }

        public Date()
        {

        }

        public Date(int j, int m, int a)
        {
            Jour = j;
            Mois = m;
            Annee = a;
        }

        public int AgeE()
        {
            return DateTime.Now.Year - Annee;
        }

        public void Saisir()
        {

            Console.Write(" Jour : ");
            Jour = int.Parse(Console.ReadLine());
            Console.Write(" Mois : ");
            Mois = int.Parse(Console.ReadLine());
            Console.Write(" Année : ");
            Annee = int.Parse(Console.ReadLine());

        }

        public override string ToString()
        {
            return " " + Jour + " / " + Mois + " / " + Annee;
        }

        public void Afficher()
        {

            Console.WriteLine(" " + Jour + " / " + Mois + " / " + Annee);
            Console.WriteLine(" Agé de : " + this.AgeE());

        }

        public void ComperDate(Date d1, Date d2)
        {
            if ((d1.Jour == d2.Jour) && (d1.Mois == d2.Mois) && (d1.Annee == d2.Annee))
            {
                Console.WriteLine(" Les deux dates sont identiques ! ");
            }
            else if ((d1.Jour < d2.Jour) && (d1.Mois == d2.Mois) && (d1.Annee == d2.Annee)) //-------------------------------------------| Cas de d2 superieur 
            {
                Console.WriteLine(d2.Jour + "/" + d2.Mois + "/" + d2.Annee + " est superieur à " + d1.Jour + "/" + d1.Mois + "/" + d1.Annee);
            }
            else if ((d1.Jour == d2.Jour) && (d1.Mois < d2.Mois) && (d1.Annee == d2.Annee))
            {
                Console.WriteLine(d2.Jour + "/" + d2.Mois + "/" + d2.Annee + " est superieur à " + d1.Jour + "/" + d1.Mois + "/" + d1.Annee);
            }
            else if ((d1.Jour == d2.Jour) && (d1.Mois == d2.Mois) && (d1.Annee < d2.Annee))
            {
                Console.WriteLine(d2.Jour + "/" + d2.Mois + "/" + d2.Annee + " est superieur à " + d1.Jour + "/" + d1.Mois + "/" + d1.Annee);
            }
            else if ((d1.Jour > d2.Jour) && (d1.Mois == d2.Mois) && (d1.Annee == d2.Annee)) //--------------------------------------------| Cas de d1 superieur
            {
                Console.WriteLine(d2.Jour + "/" + d2.Mois + "/" + d2.Annee + " est inferieur à " + d1.Jour + "/" + d1.Mois + "/" + d1.Annee);
            }
            else if ((d1.Jour == d2.Jour) && (d1.Mois > d2.Mois) && (d1.Annee == d2.Annee))
            {
                Console.WriteLine(d2.Jour + "/" + d2.Mois + "/" + d2.Annee + " est inferieur à " + d1.Jour + "/" + d1.Mois + "/" + d1.Annee);
            }
            else if ((d1.Jour == d2.Jour) && (d1.Mois == d2.Mois) && (d1.Annee > d2.Annee))
            {
                Console.WriteLine(d2.Jour + "/" + d2.Mois + "/" + d2.Annee + " est inferieur à " + d1.Jour + "/" + d1.Mois + "/" + d1.Annee);
            }
        }
    }
}