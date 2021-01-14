using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen1
{
    class PRL
    {
        public static Etudiant SaisirEtudiant()
        {
            Etudiant E = new Etudiant();

            Console.WriteLine(" Numero d'inscription : ");
            E.NumInscription = int.Parse(Console.ReadLine());
            Console.WriteLine(" Nom : ");
            E.Nom = Console.ReadLine();
            Console.WriteLine(" Date de naissance : ");
            E.DateNaiss = DateTime.Parse(Console.ReadLine());

            return (E);
        }
    }
}
