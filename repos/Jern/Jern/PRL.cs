using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;   
    
namespace Jern
{
    class PRL
    {
        public static Etudiant saisir()
        {
            Etudiant e = new Etudiant();
            Console.WriteLine("Numéro:");
            e.NumIn = int.Parse(Console.ReadLine());
            Console.WriteLine("Nom:");
            e.Nom = Console.ReadLine();
            Console.WriteLine("Date naissance:");
            e.DateNaiss = DateTime.Parse(Console.ReadLine());

            return e;
        }
      public static void afficherEnteteBulletin(int numIn)
        {
            Etudiant etudiant=DAL.GetEtudiant(numIn);
            Console.WriteLine("Num inscription : " + etudiant.NumIn);
            Console.WriteLine("Nom : " + etudiant.Nom);
            Console.WriteLine("Date de naissance : " + etudiant.DateNaiss);
            Console.WriteLine("\n");
        }
        public static void AfficherDetailNotes(DataTable tab, int numIn)
        {
            tab = DAL.GetNotes(numIn);
            int code = 1;
            Console.WriteLine("Code        Intitulé       DS        Examen      Moyenne ");

            foreach (DataRow row in tab.Rows)
            {
                Console.WriteLine(code + "           " + row["Intitule"] + "          " + row["DS"] + "          " + row["Examen"] + "          " + row["Moyenne"]);
                code++;
            }
        }
        public static void afficherMoyenneGenerale(DataTable tab,int numIns)
            {
               double moy= DAL.moyenneGenerale(numIns,tab);
               Console.WriteLine("Moyenne générale : " + moy);
           }
        public static void afficherResultat(int numIns)
        {
            afficherEnteteBulletin(numIns);
            AfficherDetailNotes(new DataTable(), numIns);
        }
        public static void AfficherBulletin(int numIns)
        {
            afficherResultat(numIns);
            afficherMoyenneGenerale(new DataTable(), numIns);
        }

    }
}
