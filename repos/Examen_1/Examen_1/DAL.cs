using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.OleDb;

namespace Examen_1
{
    class DAL
    {
        static MySqlCommand cmd;

        public static DataTable tabE()
        {
            DataTable tabEtudiant = new DataTable();
            cmd = new MySqlCommand("Select * from etudiant", DBconnexion.Link);

            MySqlDataAdapter adpt = new MySqlDataAdapter(cmd);
            adpt.Fill(tabEtudiant);

            return tabEtudiant;
        }

        public static DataTable tabM()
        {
            DataTable tabModule = new DataTable();
            cmd = new MySqlCommand("Select * from module", DBconnexion.Link);

            MySqlDataAdapter adpt = new MySqlDataAdapter(cmd);
            adpt.Fill(tabModule);

            return tabModule;
        }

        public static DataTable tabN()
        {
            DataTable tabNotes= new DataTable();
            cmd = new MySqlCommand("Select * from notes", DBconnexion.Link);

            MySqlDataAdapter adpt = new MySqlDataAdapter(cmd);
            adpt.Fill(tabNotes);

            return tabNotes;
        }

        public static DataSet  MapDB()
        {

            DataSet data = new DataSet("BD");
            DataTable tab1 = tabE();
            DataTable tab2 = tabM();
            DataTable tab3 = tabN();


            data.Tables.Add(tab1);
            data.Tables.Add(tab2);
            data.Tables.Add(tab3);

             return data;
        }

        public static void Afficher()
        {
            DataSet myBD = MapDB();

             foreach(DataRow row in myBD.Tables[0].Rows)
            {
                Console.WriteLine("NumInscription : " + row[0]  + "\n  *Nom : "+row[1] + "\n  *Date naiss : " + row[2]);

            }
   
        }
        /* public static void InsererEtudiant(Etudiant E)
         {
             E = PRL.Saisie();

             cmd = new MySqlCommand(" Insert into etudiant values (?,?,?)", DBconnexion.Link);
             cmd.Parameters.Add(new MySqlParameter("NumIscription", E.Numinsc));
             cmd.Parameters.Add(new MySqlParameter("Nom", E.Nom));
             cmd.Parameters.Add(new MySqlParameter("DateNaiss", E.datenaiss));

             cmd.ExecuteNonQuery();
             Console.WriteLine(" Ajout effectuer !! ");

         }

         public static Etudiant GetEtudiant(int Num)
         {
             Etudiant E = new Etudiant();

             cmd = new MySqlCommand(" Select *  from etudiant where NumInscription = ? ", DBconnexion.Link);
             cmd.Parameters.Add(new MySqlParameter("NumInscription", Num));

             MySqlDataReader lire = cmd.ExecuteReader();

             while (lire.Read())
             {
                 E.Numinsc = int.Parse(lire["NumInscription"].ToString());
                 E.Nom = lire["Nom"].ToString();
                 E.datenaiss = DateTime.Parse(lire["DateNaiss"].ToString());
             }

             lire.Close();
             return (E);

         }

         static string strsql = " SELECT n.IdE,n.IdM,m.Intitule,n.DS,n.Examen, ((n.DS * 0.3) + (n.Examen * 0.7)) as Moyenne from notes n  inner join module m on n.IdM = m.Code inner join  etudiant e on n.IdE= e.NumInscription where n.IdE = ? group by n.IdM  ";

         public static DataTable GetNotesEtudiant(int Num)
         {
             DataTable Tab = new DataTable();
             MySqlCommand cmd = new MySqlCommand(strsql, DBconnexion.Link);
             cmd.Parameters.AddWithValue("@n.IdE",Num);

             MySqlDataAdapter Adpt = new MySqlDataAdapter(cmd);


             Adpt.Fill(Tab);

             return Tab;

         }

         public static DataTable Etudiant()
         {
             DataTable Tab = new DataTable("Etudiant");

             cmd = new MySqlCommand(" Select * from etudiant ", DBconnexion.Link);
             MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

             adp.Fill(Tab);

             return Tab;
         }

         public static void GetEtudiant_1()
         {
             DataTable Tab = Etudiant();

             DataSet set = new DataSet(" TabSet");

             set.Tables.Add(Tab);



             Console.WriteLine(set.DesignMode);

         }

         public static Double GetMoyenneGenerale( int Num)
         {
             DataTable Tab = GetNotesEtudiant(Num);
             Double S = 0;
             int i = 0;

             foreach(DataRow row in Tab.Rows)
             {
                 S += Double.Parse(row["Moyenne"].ToString());
                 i++;
             }

             return (S / i);
         }*/



     }
    }
