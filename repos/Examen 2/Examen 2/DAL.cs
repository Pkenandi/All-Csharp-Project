using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Examen_2
{
    class DAL
    {
        static MySqlCommand cmd;

    //    public static bool Exist ( int id )
    //    {
    //        cmd = new MySqlCommand(" Select Id from article where Id = ? ", Connexion.Cnn);
    //        cmd.Parameters.Add(new MySqlParameter("Id", id));

    //      Boolean rep = Convert.ToBoolean(cmd.ExecuteScalar());

    //        if (rep)
    //            return true;
    //        else
    //            return false;

    //    }

    //    public static void Ajouter(int id, string Des)
    //    {
    //        if (Exist(id))
    //            Console.WriteLine(" Impossible d'inserer ! risque de doublon ");
    //        else
    //        {
    //            cmd = new MySqlCommand(" insert into article values (@Id,@Designation)", Connexion.Cnn);
    //            cmd.Parameters.AddWithValue("@Id", id);
    //            cmd.Parameters.AddWithValue("@Designation", Des);

    //            cmd.ExecuteNonQuery();

    //            Console.WriteLine(" Ajout effectuer !! ");

    //        }
    //    }

    //    public static int GetQuantity( int idS, int idArt)
    //    {
    //        cmd = new MySqlCommand(" select Quantite from stockartsite where Idart = ? and Idsite = ? ", Connexion.Cnn);
    //        cmd.Parameters.Add(new MySqlParameter("Idart", idArt));
    //        cmd.Parameters.Add(new MySqlParameter("Idsite", idS));

    //        int Q = Convert.ToInt32(cmd.ExecuteScalar());

    //        return Q;

    //    }

    //    public static void UpdateQuantity(int idS, int idArt, int N)
    //    {
    //        if(N < 0)
    //        {
    //            cmd = new MySqlCommand(" Update stockartsite set Quantite = Quantite-1 where Idart = ? and Idsite = ? ", Connexion.Cnn);
    //            cmd.Parameters.Add(new MySqlParameter("Idart", idArt));
    //            cmd.Parameters.Add(new MySqlParameter("Idsite", idS));

    //            cmd.ExecuteNonQuery();
    //        }else if( N > 0)
    //        {
    //            cmd = new MySqlCommand(" Update stockartsite set Quantite = Quantite+1 where Idart = ? and Idsite = ? ", Connexion.Cnn);
    //            cmd.Parameters.Add(new MySqlParameter("Idart", idArt));
    //            cmd.Parameters.Add(new MySqlParameter("Idsite", idS));

    //            cmd.ExecuteNonQuery();
    //        }

    //    }

    //    public static void ConstrainedUpdateQuantity(int idS, int idArt, int N)
    //    {
    //        int crrQty = GetQuantity(idS, idArt);
            
    //        if((crrQty > 0 || crrQty == 0) && N > 0)
    //        {
    //            UpdateQuantity(idS, idArt, N);

    //        }else if(crrQty == 0 && N < 0)
    //        {
    //            Console.WriteLine(" Impossible de faire la mise à jour au risque d'avoir un stock negatif !! ");
    //        }
    //        else if(crrQty > 0 && N < 0)
    //        {
    //            UpdateQuantity(idS, idArt, N);
    //        }
    //    }
    }
}
