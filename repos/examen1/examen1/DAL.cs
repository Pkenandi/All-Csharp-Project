using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace examen1
{
    class DAL
    {
        static OleDbCommand cmd;
        
        public static void Inserer()
        {
            Etudiant E = PRL.SaisirEtudiant();

            cmd = new OleDbCommand(" Insert into Etudiant values (?,?,?) ", DBconnection.cnn);
            cmd.Parameters.Add(new OleDbParameter("NumInscription", E.NumInscription));
            cmd.Parameters.Add(new OleDbParameter("Nom", E.Nom));
            cmd.Parameters.Add(new OleDbParameter("DateNaiss", E.DateNaiss));

            cmd.ExecuteNonQuery();

        }

        public static Etudiant GetEtudiant(int numIns)
        {
            cmd = new OleDbCommand("Select* from Etudiant where NumInscription = ?",DBconnection.cnn);
            cmd.Parameters.Add(new OleDbParameter("NumInscription", numIns));
            OleDbDataReader rt = cmd.ExecuteReader();
            Etudiant etudiant = new Etudiant();
            
            while(rt.Read())
            {
                etudiant.NumInscription = int.Parse(rt["NumInscription"].ToString());
                etudiant.Nom = rt["Nom"].ToString();
                etudiant.DateNaiss = DateTime.Parse(rt["DateNaiss"].ToString());
            }
            return etudiant;
        }

        //static string Request = "SELECT [IdE],[IdM], [Intitule], [DS],[Examen] ,(([DS] * 0.3) + ([Examen] * 0.7)) as Moyenne from Notes INNER JOIN Module ON [IdM] = [Code] INNER JOIN Etudiant ON [IdE] = [NumInscription] WHERE [IdE] = ?";

        public static DataTable GetNotesEtudiant( int Num )
        {
            DataTable Tab = new DataTable();
            try
            {
                
                string Request = "SELECT n.IdE,n.IdM, m.Intitule, n.DS,n.Examen ,((n.DS * 0.3) + (n.Examen * 0.7)) as Moyenne from Module m inner join Notes n on m.Code = n.IdM inner join Etudiant e on n.IdE = e.NumInscription   WHERE IdE = 3";

                cmd = new OleDbCommand(Request, DBconnection.cnn);
                cmd.ExecuteNonQuery();
                OleDbDataAdapter Adpt = new OleDbDataAdapter(cmd);

                Adpt.Fill(Tab);
                return Tab;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public static void afficher(int num)
        {
            cmd = new OleDbCommand(" Select * from Etudiant where NumInscription = ?", DBconnection.cnn);
            cmd.Parameters.Add(new OleDbParameter("NumInscription", num));

            OleDbDataAdapter Adp = new OleDbDataAdapter(cmd);

            DataTable Tab = new DataTable();
            Adp.Fill(Tab);

            foreach(DataRow  row in Tab.Rows)
            {
                Console.WriteLine(" Num : " + row["NumInscription"] + " Nom : " + row["Nom"] + " Date naissance : " + row["DateNaiss"]);
            }
        }
    }
}
