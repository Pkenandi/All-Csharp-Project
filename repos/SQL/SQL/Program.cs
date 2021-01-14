using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlCommand cmd;
            MySqlDataReader lire;
            MySqlConnection cnn = new MySqlConnection(" Database = exsql; Server = localhost; UserID = root; Pwd = '' ");
            cnn.Open();

            //for(int i = 0; i < 4;i++ )
            //{
            //    Console.Write(" No voyage : ");
            //    int nvt = int.Parse(Console.ReadLine());
            //    Console.Write(" No client : ");
            //    int nvy = int.Parse(Console.ReadLine());
            //    Console.Write(" Date inscription : ");
            //    DateTime dateret = DateTime.Parse(Console.ReadLine());

            //    cmd = new MySqlCommand(" insert into inscription values (@NoV,@NoC,@DateInsc)", cnn);
            //    cmd.Parameters.AddWithValue("@NoV", nvy);
            //    cmd.Parameters.AddWithValue("@NoC", nvt);
            //    cmd.Parameters.AddWithValue("@DateInsc", dateret);

            //    cmd.ExecuteNonQuery();
            //}


            Console.WriteLine(" 1. Question I ");
            Console.WriteLine(" 2. Question II ");
            Console.WriteLine(" 3. Question III ");
            Console.WriteLine(" 4. Question VI ");
            Console.WriteLine(" 5. Question V ");
            Console.WriteLine(" 6. Question VI ");
            Console.WriteLine(" 7. Question VII ");
            Console.WriteLine(" 8. Question VIII ");
            Console.WriteLine(" ==> :  ");
            int rep = int.Parse(Console.ReadLine());

            switch (rep)
            {
                case 1:
                    {
                        cmd = new MySqlCommand(" Select Endroit from visite v, programmes p where v.NoVisite = p.NoVt and year(p.DateVisite) = 2015 order by Endroit asc ", cnn);
                        lire = cmd.ExecuteReader();

                        while(lire.Read())
                        {
                            Console.WriteLine("  " + lire.GetString("Endroit"));
                        }
                        lire.Close();

                        break;
                    }

                case 2:
                    {
                        cmd = new MySqlCommand(" Select count(*) from client c, inscription i where c.NoClient = i.NoC ", cnn);
                        int nbr = Convert.ToInt32(cmd.ExecuteScalar());

                        if (nbr == 0)
                            Console.WriteLine(" aucun client ");
                        else
                            Console.WriteLine(" <" + nbr + "> Client(s)  ");

                        break;
                    }

                case 3:
                    {
                        cmd = new MySqlCommand(" Select *  from voyages where Prix = ( Select min(Prix) from voyages ) ", cnn);
                        lire = cmd.ExecuteReader();

                        while(lire.Read())
                        {
                            Console.WriteLine(" Num  V : " + lire.GetDouble(0) + " Ville dep : " + lire.GetString(1) + " Ville Arr : " + lire.GetString(2) + " Date dep : " + lire.GetString(3) + " Date ret : " + lire.GetString(4) + " Prix : " + lire.GetDouble(5));
                        }

                        break;
                    }

                case 4:
                    {
                        cmd = new MySqlCommand(" SELECT v.Endroit, COUNT(*) as nbr FROM visite v, programmes p WHERE year(p.DateVisite) = 2015 GROUP BY v.Endroit HAVING (nbr) > 2 ", cnn);
                        lire =  cmd.ExecuteReader();

                        while(lire.Read())
                        {
                            Console.WriteLine("  " + lire.GetString("Endroit"));

                        }
                        break;
                    }

                case 5:
                    {


                        break;
                    }
            }

        }

    }

}
