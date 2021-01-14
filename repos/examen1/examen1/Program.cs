using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace examen1
{
    class Program
    {
        static void Main(string[] args)
        {
            OleDbConnection connect = DBconnection.cnn;
            connect.Open();
            Console.WriteLine(" You're connected !! ");

            /*DAL.Inserer();
            Console.WriteLine(" Ajout effectuer !! ");*/

            //Etudiant etudiant = DAL.GetEtudiant(2);
            //Console.WriteLine("NumInscription:" + etudiant.NumInscription + "\nNom:" + etudiant.Nom);
            DataTable T = DAL.GetNotesEtudiant(3);
            foreach (DataRow I in T.Rows)
            {
                Console.WriteLine(T.Rows.Count);
            }

            DAL.afficher(3);
            
            connect.Close();
        }
    }
}
