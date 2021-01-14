using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Examen
{
    class ExamenDAL
    {
        static MySqlCommand cmd;
        static MySqlDataReader lire;
        
       public static void AddEtudiant()
        {
            Etudiant E = new Etudiant();
            Etudiant Et = new Etudiant();

            Et = ExamenView.GetInfoEtudiant(E);

            cmd = new MySqlCommand(" Insert into etudiant values (@NumInscription, @Nom, @DateNaissance)", Connexion.Connect());
            cmd.Parameters.AddWithValue("@NumInscription", Et.NumInst);
            cmd.Parameters.AddWithValue("@Nom", Et.Nom);
            cmd.Parameters.AddWithValue("@DateNaissance", Et.DateNaiss);

            cmd.ExecuteNonQuery();

        }

        public static Etudiant GetEtudiant(int Num)
        {
            Etudiant Et = new Etudiant();

            cmd = new MySqlCommand(" select * from etudiant where NumInscription = ?", Connexion.Connect());
            cmd.Parameters.Add(new MySqlParameter("NumInscription", Num));

            lire = cmd.ExecuteReader();
            
            while(lire.Read())
            {
                Et.NumInst = lire.GetInt32("NumInscription");
                Et.Nom = lire.GetString("Nom");
                Et.DateNaiss = lire.GetDateTime("DateNaiss");
            }

            Console.WriteLine(" Num : " + Et.NumInst + "\n Nom : " + Et.Nom + "\n Date naissance : " + Et.DateNaiss);

            lire.Close();

            return (Et);
            
        }

        string requete = " SELECT n.IdE, n.IdM, m.Intitule, n.DS, n.Examen, ((n.DS*0.3)+(n.Examen*0.7)) from notes n INNER JOIN module m on m.Code = n.IdM INNER JOIN etudiant e on e.NumInscription = n.IdE WHERE n.IdE = 10 GROUP BY n.IdM ";

        public static  void AddModule()
        {
            Module M = new Module(),Md = ExamenView.GetModuleEtudiant(M);

            cmd = new MySqlCommand(" Insert into module values (@Code, @Intitule)", Connexion.Connect());
            cmd.Parameters.AddWithValue("@Code", Md.Code);
            cmd.Parameters.AddWithValue("@Intitule", Md.Titre);

            cmd.ExecuteNonQuery();

        }

        public static void AddNotes()
        {
            Notes N = new Notes(), Nt = new Notes();

            Nt = ExamenView.GetNotesEtudiant(N);

            cmd = new MySqlCommand(" Insert into notes values (@IdEtudiant,@IdModule,@DS,@Examen)", Connexion.Connect());
            cmd.Parameters.AddWithValue("@IdEtudiant",Nt.IdEtudiant);
            cmd.Parameters.AddWithValue("@IdModule", Nt.IdModule);
            cmd.Parameters.AddWithValue("@DS", Nt.DS);
            cmd.Parameters.AddWithValue("@Examen", Nt.Examen);

            cmd.ExecuteNonQuery();

        }

        public static double GetMoyenneModule(int Num)
        {
            double Nds = 0 , Nexam = 0 , MoyMod ;

            cmd = new MySqlCommand(" Select DS, Examen from notes where IdEtudiant = ?", Connexion.Connect());
            MySqlParameter P = new MySqlParameter("NumInscription", Num);
            cmd.Parameters.Add(P);

            MySqlDataReader reader = cmd.ExecuteReader();
            
                while (reader.Read())
                {
                    Nds = reader.GetDouble("DS");
                    Nexam = reader.GetDouble("Examen");
                }

                MoyMod = (0.3 * Nds) + (0.7 * Nexam);

            reader.Close();

            return (MoyMod);
        }

        public static double GetMoyenneGenerale(int Num)
        {
            double Nds = 0, Nexam = 0, MoyMod = 0,S = 0;
            int NbrMoy = 0;

            cmd = new MySqlCommand(" Select DS, Examen from notes where IdEtudiant = ?", Connexion.Connect());
            MySqlParameter P = new MySqlParameter("NumInscription", Num);
            cmd.Parameters.Add(P);

            MySqlDataReader reader = cmd.ExecuteReader();
            

            while (reader.Read())
            {
                Nds = reader.GetDouble("DS");
                Nexam = reader.GetDouble("Examen");

                MoyMod = (0.3 * Nds) + (0.7 * Nexam);
                S += MoyMod;
                NbrMoy++;

            }
            
            return (S/NbrMoy);
        }
    }
}
