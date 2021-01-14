using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Examen
{
    class ExamenView
    {
        public static MySqlCommand cmd;

        public static Etudiant GetInfoEtudiant(Etudiant E)
        {
            Console.Write(" Numero d'inscription : ");
            E.NumInst = int.Parse(Console.ReadLine());
            Console.Write(" Nom : ");
            E.Nom = Console.ReadLine();
            Console.Write(" Date naissance : ");
            E.DateNaiss = DateTime.Parse(Console.ReadLine());

            return (E);
        }

        public static Notes GetNotesEtudiant(Notes N)
        {
            Console.Write(" Id Etudiant : ");
            N.IdEtudiant = int.Parse(Console.ReadLine());
            Console.Write(" Id Module : ");
            N.IdModule = int.Parse(Console.ReadLine());
            Console.Write(" Note DS : ");
            N.DS = float.Parse(Console.ReadLine());
            Console.Write(" Note examen : ");
            N.Examen = float.Parse(Console.ReadLine());

            return N;
        }

        public static Module GetModuleEtudiant(Module M)
        {
            Console.Write(" Code module : ");
            M.Code = int.Parse(Console.ReadLine());
            Console.Write(" Titre module : ");
            M.Titre = Console.ReadLine();

            return M;
        }

        public static void En_Tete(int Num)
        {
            cmd = new MySqlCommand(" Select * from etudiant where NumInscription = ?", Connexion.Connect());
            MySqlParameter P = new MySqlParameter("NumInscription", Num);
            cmd.Parameters.Add(P);

            MySqlDataReader Lire = cmd.ExecuteReader();

            while(Lire.Read())
            {
                Console.WriteLine(" Num inscription : " + Lire.GetDouble("NumInscription"));
                Console.WriteLine(" Nom : " + Lire.GetString("Nom"));
                Console.WriteLine(" Date de naissance : " + Lire.GetString("DateNaissance"));
            }

            Lire.Close();
        }

        public static void DetailsNotes(int Num)
        {
            int code = 1;
            cmd = new MySqlCommand(" Select m.Intitule,n.DS,n.Examen from module m inner join notes n on m.Code = n.IdModule where IdEtudiant = ?", Connexion.Connect());
            MySqlParameter P = new MySqlParameter("IdEtudiant", Num);
            cmd.Parameters.Add(P);

            MySqlDataReader Lire = cmd.ExecuteReader();

            Console.WriteLine(" Code        Titre                   DS          Examen          Moyenne");
            while (Lire.Read())
            {
                Console.WriteLine("  " + code + "           " + Lire["Intitule"].ToString() + "                    " + Lire.GetDouble("DS") + "            " + Lire.GetDouble("Examen") + "            " + ExamenDAL.GetMoyenneModule(Num));
                code++;
            }

            Lire.Close();
        }
    }
}
