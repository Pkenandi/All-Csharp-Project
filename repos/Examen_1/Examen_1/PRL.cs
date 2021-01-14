//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.OleDb;
//using System.Data;

//namespace Examen_1
//{
//    class PRL
//    {
//        public static Etudiant Saisie()
//        {
//            Etudiant E = new Etudiant();

//            Console.Write(" Num inscription : ");
//            E.Numinsc = int.Parse(Console.ReadLine());
//            Console.Write(" Nom : ");
//            E.Nom = Console.ReadLine();
//            Console.Write(" Date Naissance : ");
//            E.datenaiss = DateTime.Parse(Console.ReadLine()); 

//            return E;
//        }

//        public static void AfficherEnteteBulletin(int Num)
//        {
//            Etudiant E = DAL.GetEtudiant(Num);

//            Console.WriteLine(" Num inscription : " + E.Numinsc);
//            Console.WriteLine(" Nom : " + E.Nom);
//            Console.WriteLine(" Date de naissance : " + E.datenaiss);

//            Console.WriteLine("\n");

//        }

//        public static void AfficherDetailsNotesBulletin(int Num)
//        {
//            DataTable Tab = DAL.GetNotesEtudiant(Num);
//            int Code = 1;

//            Console.WriteLine(" Code    Intitulé        DS        Examen      Moyenne  ");

//            foreach (DataRow row in Tab.Rows)
//            {
//                Console.WriteLine("  " + Code + "       " + row["Intitule"] + "             " + row["DS"] + "         " + row["Examen"] + "          " + row["Moyenne"]);
               
//                Code++;
//            }

//        }

//        public static void AfficherMoyenneGenerale(int Num)
//        {

//            Double Moy = DAL.GetMoyenneGenerale(Num);

//            Console.WriteLine("\n");
//            Console.WriteLine(" Moyenne générale  :  " + Moy);

//        }

//        public static void AfficherResultats(int Num)
//        {

//            AfficherDetailsNotesBulletin(Num);
//            AfficherMoyenneGenerale(Num);

//        }

//        public static void AfficherBulletin(int Num)
//        {

//            AfficherEnteteBulletin(Num);
//            AfficherResultats(Num);

//        }
//    }
//}
