using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Jern
{
    class DAL
    {
        static MySqlCommand cmd;

        public static void InsererEtudiant()
        {
            Etudiant etudiant = PRL.saisir();
            MySqlConnection cnn = DBConnection.GetConnection();
            cnn.Open();
            cmd = new MySqlCommand("insert into etudiant values (?,?,?) ",cnn);
            cmd.Parameters.Add(new MySqlParameter("NumIn", etudiant.NumIn));
            cmd.Parameters.Add(new MySqlParameter("Nom", etudiant.Nom));
            cmd.Parameters.Add(new MySqlParameter("DateNaiss", etudiant.DateNaiss));

            cmd.ExecuteNonQuery();
            cnn.Close();
         }
        public static Etudiant GetEtudiant(int numIn)
        {
            Etudiant etudiant = new Etudiant();
            MySqlConnection cnn = DBConnection.GetConnection();
            cnn.Open();
           cmd = new MySqlCommand("select * from etudiant where NumInscription=?",cnn);
            cmd.Parameters.Add(new MySqlParameter("NumInscription", numIn));

            MySqlDataReader read = cmd.ExecuteReader();

            while(read.Read())
            {
                etudiant.NumIn = int.Parse(read["NumInscription"].ToString());
                etudiant.Nom = read["Nom"].ToString();
                etudiant.DateNaiss = DateTime.Parse(read["DateNaiss"].ToString());
            }
            read.Close();
            cnn.Close();
            return etudiant;
        }

        static string requete = "Select IdE,IdM,module.Intitule,DS,Examen,((0.3*DS)+(0.7*Examen)) as Moyenne From notes Inner Join etudiant On notes.IdE=etudiant.NumInscription inner join module on notes.IdM=module.Code where IdE= ?";

        public static DataTable GetNotes(int numIn)
        {
            DataTable tab = new DataTable();
            MySqlConnection cnn = DBConnection.GetConnection();
            cnn.Open();
            cmd = new MySqlCommand(requete, cnn);
            cmd.Parameters.Add(new MySqlParameter("IdE", numIn));
            MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);

            adapt.Fill(tab);
            cnn.Close();
            return tab;
        }

        public static double moyenneGenerale(int numIns,DataTable tab)
        {
            tab = GetNotes(numIns);
            double s = 0;
            int i = 0;
            MySqlConnection cnn = DBConnection.GetConnection();
            cnn.Open();
 
            foreach (DataRow row in tab.Rows)
            {
                s += double.Parse(row["Moyenne"].ToString());
                i++;
            }
            cnn.Clone();
            return (s / i);
        }
    }
}
