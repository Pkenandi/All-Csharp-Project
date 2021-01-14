using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace TP3
{
    class ArticleDAL
    {
        static OleDbConnection db;
        static OleDbCommand cmd;
        static bool Connected = false;

        public static void ConnectTo(string DataBaseFile)
        {
            string Link = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + DataBaseFile;

            db = new OleDbConnection(Link);

            db.Open();
            Connected = true;
            
            Console.WriteLine("         -- Connected --   ");

        }

        public static void DisconnectTo(string DataBaseFile)
        {
            db = new OleDbConnection(DataBaseFile);

            db.Close();
            Connected = false;
            Console.WriteLine(" Vous etes deconnectez ! ");

        }

        public static void Add(Article a)
        {
            if(Connected)
            {
                cmd = new OleDbCommand(" INSERT INTO Article values (a.Reference,a.Designation, a.Prix)", db);
                    cmd.Parameters.AddWithValue("@Reference", a.Reference);
                        cmd.Parameters.AddWithValue("@Designation", a.Designation);
                            cmd.Parameters.AddWithValue("@Prix", a.Prix);

                try
                {
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("Ajout avec succès!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            else
            {
                Console.WriteLine(" Vous etes hors-connection !!");
            }
        }

        public static void Delete(int Ref)
        {

            if( Connected)
            {
                OleDbCommand Cmd = new OleDbCommand(" select count(*) from Article where Reference = ? ", db);
                OleDbParameter par = new OleDbParameter("Reference", Ref);
                Cmd.Parameters.Add(par);

                int N = (int)Cmd.ExecuteScalar();

                cmd = new OleDbCommand(" DELETE * from Article where Ref = Reference ", db);
                    cmd.Parameters.AddWithValue("@Reference", Ref);

                try
                {
                    if (N > 0)
                    {
                        cmd.ExecuteNonQuery();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(" L'article < " + Ref + " > a eté supprimer ! ");
                    }else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Cette reference n'existe pas !!");
                    }
                }catch ( Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            else
            {
                Console.WriteLine(" Vous n'etes  pas connectez !! ");
            }

        }

        public static void Update(int Ref, Article a)
        {

            if (Connected)
            {
                try
                {
                    cmd = new OleDbCommand(" Select count(*) from Article where Reference = ? ", db);
                    OleDbParameter par = new OleDbParameter("Reference", Ref);
                    cmd.Parameters.Add(par);

                    int Nbr = (int)cmd.ExecuteScalar();

                    if (Nbr > 0)
                    {
                      
                        OleDbCommand command = new OleDbCommand("Update Article set  Reference = a.Reference, Designation = a.Designation, Prix = a.Prix WHERE Reference = Ref", db);
                        command.Parameters.AddWithValue("@Reference", a.Reference);
                        command.Parameters.AddWithValue("@Designation", a.Designation);
                        command.Parameters.AddWithValue("@Prix", a.Prix);
                        command.Parameters.AddWithValue("@Reference", Ref);

                        command.ExecuteNonQuery();
                            command.Parameters.Clear();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(" Mise a jour effectuer !! ");

                    } else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Cet Article n'existe pas dans la base !");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } else
            {
                Console.WriteLine(" Vous etes hors-connexion ");
            }

        }

        public static Article SelectByRef(int Ref)
        {
            Article Art = new Article();

            if(Connected)
            {
                try
                {
                    cmd = new OleDbCommand(" Select * from Article where Reference = Ref ", db);
                    cmd.Parameters.AddWithValue("@Reference", Ref);

                    OleDbDataReader Rdr = cmd.ExecuteReader();

                    if(Rdr != null)
                    {
                        if(Rdr.Read())
                        {
                            Art.Reference = int.Parse(Rdr[0].ToString());
                            Art.Designation = (string)Rdr[1];
                            Art.Prix = float.Parse(Rdr[2].ToString());
                        }
                        return Art;
                    }
                }catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }
            }else
            {
                Console.WriteLine(" Vous etes hors-connexion !! ");
            }

            return null;
        }

        public static List<Article> SelectAll()
        {
            List<Article> LesArticles = new List<Article>();
            Article Art;

            if (Connected)
            {
                cmd = new OleDbCommand(" Select * from Article ",db);
                OleDbDataReader Rdr = cmd.ExecuteReader();

                if(Rdr != null)
                {
                    while(Rdr.Read())
                    {
                        Art = new Article();

                        Art.Reference = int.Parse(Rdr[0].ToString());
                        Art.Designation = Rdr[1].ToString();
                        Art.Prix = float.Parse(Rdr[2].ToString());

                        LesArticles.Add(Art);
                    }

                }
            }

                return LesArticles;
        }
    }
}