using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Etudiant : Personne
    {
        string NomInst;
        int NumTD;

        public Etudiant() : base()
        {

        }

        /*public Etudiant(Date d)
        {
            D = new Date(d.Jour, d.Mois, d.Annee);
        }*/

        public Etudiant(string N, string P, Date dat, string NI, int NT) : base(N, P, dat)
        {
            this.NomInst = NI;
            this.NumTD = NT;

        }


        public override void Saisir()
        {

            base.Saisir();
            Console.Write(" Nom de L'institut : ");
            NomInst = Console.ReadLine();
            Console.Write(" Numero de TD : ");
            NumTD = int.Parse(Console.ReadLine());

        }

        public override string ToString()
        {
            return base.ToString() + " " + NomInst + " appartenant au TD numero " + NumTD;
        }
        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("  " + NomInst + " appartenant au TD numero " + NumTD);

        }

    }
}
