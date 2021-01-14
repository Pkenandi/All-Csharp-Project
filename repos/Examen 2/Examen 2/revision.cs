using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Examen_2
{
    class revision
    {
        static MySqlCommand cmd;
        
        public static Boolean Exit( int Id)
        {
            cmd = new MySqlCommand(" select * from  article where id = ? ", Connexion.Cnn);
            cmd.Parameters.Add(new MySqlParameter("id", Id));

            Boolean Rep = Convert.ToBoolean(cmd.ExecuteScalar());

            return Rep;
        }

        public static void add(int Id, string Des)
        {
            if (Exit(Id))
                Console.WriteLine(" Risque des doublons !! ");
            else
            {
                cmd = new MySqlCommand(" insert into article values (@id,@designation)", Connexion.Cnn);
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@designation", Des);

                cmd.ExecuteNonQuery();
                Console.WriteLine(" article ajouter avec succés !! ");

            }
        }

        public static int GetQuantity(int IdArt, int IdSite)
        {
            string strsql = "select quantite from stockartsite where idsite = ? and idart = ?";
            cmd = new MySqlCommand(strsql, Connexion.Cnn);
            cmd.Parameters.Add(new MySqlParameter("idsite", IdSite));
            cmd.Parameters.Add(new MySqlParameter("idart", IdArt));

            int Q = Convert.ToInt32(cmd.ExecuteScalar());

            return Q;
        }

        public static void UpdateQuantity_1(int Idart, int Idsite, int N)
        {
            if(N > 0)
            {
                cmd = new MySqlCommand(" update stockartsite set quantite = (quantite + ?) where idart = ? and idsite = ?", Connexion.Cnn);
                cmd.Parameters.Add(new MySqlParameter("quantite", N));
                cmd.Parameters.Add(new MySqlParameter("idart", Idart));
                cmd.Parameters.Add(new MySqlParameter("idsite", Idsite));


                cmd.ExecuteNonQuery();
                Console.WriteLine(" quantite mise a jour (+ " + N + " ) ");

            }else if( N < 0)
            {
                cmd = new MySqlCommand(" update stockartsite set quantite = (quantite + ?) where idart = ? and idsite = ?", Connexion.Cnn);
                cmd.Parameters.Add(new MySqlParameter("quantite", N));
                cmd.Parameters.Add(new MySqlParameter("idart", Idart));
                cmd.Parameters.Add(new MySqlParameter("idsite", Idsite));

                cmd.ExecuteNonQuery();
                Console.WriteLine(" quantite mise a jour (- " + N + " ) ");
            }

        }

        public static void ConstrainedUpdateQuantity( int idart, int idsite, int N)
        {
            int CurrentQ = GetQuantity(idart, idsite);

            if( CurrentQ + N >= 0)
            {
                UpdateQuantity_1(idart, idsite, N);

            }else 
                if( CurrentQ + N < 0 )
            {
                Console.WriteLine(" Risque d'avoir un stock negatif !! ");
            }

        }

        public static void Transfert(int idAF, int idSF, int idSTo, int idATo)
        {
            int QFrom = GetQuantity(idAF, idSF);
            int Qto = GetQuantity(idATo, idSTo);

            cmd = new MySqlCommand(" Update stockartsite set Quantite = ? where Idart = ? and Idsite = ? ", Connexion.Cnn);
            cmd.Parameters.Add(new MySqlParameter("Quantite", QFrom));
            cmd.Parameters.Add(new MySqlParameter("Idart", idAF));
            cmd.Parameters.Add(new MySqlParameter("Idsite", idSF));

            cmd.ExecuteNonQuery();

            //MySqlCommand Cmd = new MySqlCommand(" Update stockartsite set Quantite = ? where Idart = ? and Idsite = ? ", Connexion.Cnn);
            //cmd.Parameters.Add(new MySqlParameter("Quantite", QFrom));
            //cmd.Parameters.Add(new MySqlParameter("Idart", idAF));
            //cmd.Parameters.Add(new MySqlParameter("Idsite", idSF));

            
            //Cmd.ExecuteNonQuery();

        }
    }
}
