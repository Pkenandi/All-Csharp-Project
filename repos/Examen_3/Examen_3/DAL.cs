using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Examen_3
{
    class DAL
    {
        static MySqlCommand cmd;

        public static Facture GetFacture(int Ref)
        {
            Facture F = new Facture();

            cmd = new MySqlCommand(" Select * from facture where Fref = ? ", DBconnection.Cnn);
            cmd.Parameters.Add(new MySqlParameter("Fref", Ref));

            MySqlDataReader Lire = cmd.ExecuteReader();

            while (Lire.Read())
            {
                F.Ref = int.Parse(Lire["Fref"].ToString());
                F.IdClient = int.Parse(Lire["IdC"].ToString());
                F.DateF = DateTime.Parse(Lire["DateF"].ToString());
                F.Montant = float.Parse(Lire["MontantTotal"].ToString());
                
            }
            
            Lire.Close();
            return F;
            
        }

        public static DataTable GetDetailReglements(int Ref)
        {
            cmd = new MySqlCommand(" Select * from reglement where  Ref = ? ", DBconnection.Cnn);
            cmd.Parameters.Add(new MySqlParameter("Ref", Ref));

            MySqlDataAdapter Adp = new MySqlDataAdapter(cmd);
            DataTable Tab = new DataTable();
            Adp.Fill(Tab);

            return Tab;
        }

        public static Double CalculTotalReglements(int Ref)
        {
            DataTable T = GetDetailReglements(Ref);

            double S = 0;

            foreach(DataRow row in T.Rows)
            {
                S += Double.Parse(row["Montant"].ToString());
            }

            return S;
        }


    }
}
