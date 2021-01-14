using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Examen_3
{
    class PRL
    {

        public static void AfficherEnteteFacture(int Ref)
        {
            MySqlCommand cmd = new MySqlCommand(" SELECT Fref, IdC, Nom, DateF, MontantTotal from facture f INNER JOIN client c on f.IdC = c.Id WHERE Fref = ?", DBconnection.Cnn);
            cmd.Parameters.Add(new MySqlParameter("Fref", Ref));

            MySqlDataReader Lire = cmd.ExecuteReader();

            while(Lire.Read())
            {

                Console.WriteLine(" Reference :  " + Lire.GetInt32("Fref"));
                Console.WriteLine(" Identifiant du Client : " + Lire.GetInt32("IdC"));
                Console.WriteLine(" Nom du Client : " + Lire.GetString("Nom"));
                Console.WriteLine(" Date de la Facture : " + Lire.GetDateTime("DateF"));
                Console.WriteLine(" Montant Total : " + Lire.GetDouble("MontantTotal"));

            }

            Lire.Close();
        }

        public static void AfficherDetailsReglements(DataTable T, int Ref)
        {
            T = DAL.GetDetailReglements(Ref);

            Console.WriteLine("  Date                   Montant   ");
            foreach(DataRow row in T.Rows)
            {
                Console.WriteLine("  " + row["DateReg"] + "    " + row["Montant"]);
            }
        }

        public static void AfficherBulanReglements(DataTable T, int Ref)
        {
            T = DAL.GetDetailReglements(Ref);
            Facture F = DAL.GetFacture(Ref);
            Double S = 0, Reste = 0;

            foreach(DataRow row in T.Rows)
            {
                S += Double.Parse(row["Montant"].ToString()); // Somme des Montant
            }

            Reste = (F.Montant - S);

            Console.WriteLine(" Montant total des reglements : " + S);
            if (Reste < 0)
                Console.WriteLine(" Vous avez une dette envers le Client de  : " + Reste);
            else
                Console.WriteLine(" Reste à payer : " + Reste);

        }

        public static void AfficherFactureReglements(int Ref)
        {
            AfficherEnteteFacture(Ref);
            Console.WriteLine("\n");
            AfficherDetailsReglements(new DataTable(), Ref);
            Console.WriteLine("\n");
            AfficherBulanReglements(new DataTable(), Ref);
        }

    }
}
