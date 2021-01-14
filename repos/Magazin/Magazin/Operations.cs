using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Magazin
{
    
    class Operations
    {
        public static MySqlCommand cmd;
        public static MySqlDataReader Lire;
        public static DataTable Tab;

        public static List<Fournisseur> AllFournisseur = new List<Fournisseur>();
        public static List<Magazin> AllMagazin = new List<Magazin>();

        public static void AjoutMagazin(Magazin M)
        {
            Console.Write(" Num Magazin : ");
            M.NumMag = int.Parse(Console.ReadLine());
            Console.Write(" Localisation : ");
            M.LocMag = Console.ReadLine();
            Console.Write(" Nom du gerant : ");
            M.Gerant = Console.ReadLine();

            cmd = new MySqlCommand(" Insert into magazin values(@NumMag, @LocMag, @GerantMag)", Connexion.Connect);
            cmd.Parameters.AddWithValue("@NumMag", M.NumMag);
            cmd.Parameters.AddWithValue("@LocMag", M.LocMag);
            cmd.Parameters.AddWithValue("@GerantMag", M.Gerant);

            cmd.ExecuteNonQuery();

            Console.WriteLine(" Ajout effectué !!");

        }

        public static void AjoutFournisseur(Fournisseur F)
        {
            Console.Write(" Num fournisseur : ");
            F.NumF = int.Parse(Console.ReadLine());
            Console.Write(" Nom fournisseur : ");
            F.NomF = Console.ReadLine();

            cmd = new MySqlCommand(" Insert into fournisseur values (@NumF,@NomF)", Connexion.Connect);
            cmd.Parameters.AddWithValue("@NumF", F.NumF);
            cmd.Parameters.AddWithValue("@NomF", F.NomF);

            cmd.ExecuteNonQuery();

            Console.WriteLine(" Ajout effectué !! ");

        }

        public static void AjoutArticle(Article A)
        {
            Console.Write(" Num Article : ");
            A.NumA = int.Parse(Console.ReadLine());
            Console.Write(" Nom Article : ");
            A.NomA = Console.ReadLine();
            Console.Write(" Poids Article : ");
            A.Poids = float.Parse(Console.ReadLine());
            Console.Write(" Couleur Article : ");
            A.Couleur = Console.ReadLine();
            Console.Write(" Prix d'Achat :");
            A.PrixAchat = float.Parse(Console.ReadLine());
            Console.Write(" Prix de Vente : ");
            A.PrixVente = float.Parse(Console.ReadLine());
            Console.Write(" Num du Frs de l'article : ");
            A.FArticle = int.Parse(Console.ReadLine());

            cmd = new MySqlCommand("Insert into article values(@NumA, @NomA, @PoidsA, @Couleur, @PrixAchat, @PrixVente, @ArtF) ", Connexion.Connect);
            cmd.Parameters.AddWithValue("@NumA",A.NumA);
            cmd.Parameters.AddWithValue("@NomA",A.NomA);
            cmd.Parameters.AddWithValue("@PoidsA",A.Poids);
            cmd.Parameters.AddWithValue("@Couleur",A.Couleur);
            cmd.Parameters.AddWithValue("@PrixAchat",A.PrixAchat);
            cmd.Parameters.AddWithValue("@PrixVente",A.PrixVente);
            cmd.Parameters.AddWithValue("@ArtF",A.FArticle);

            cmd.ExecuteNonQuery();

            Console.WriteLine("Ajout effectué !! \n");
        }

        public static void LocMag()
        {
            cmd = new MySqlCommand("Select NumMag, LocMag from magazin ", Connexion.Connect);

            Lire = cmd.ExecuteReader();

            while (Lire.Read())
            {
                Console.WriteLine(" Numero : " + Lire.GetDouble("NumMag") + " Localisation Magazin  : " + Lire.GetString("LocMag"));
            }

            Lire.Close();

        }

        public static void ArtPvX()
        {

            cmd = new MySqlCommand(" Select NumA, NomA, PrixAchat, PrixVente from article where (PrixVente >= PrixAchat * 2)  ", Connexion.Connect);

            Lire = cmd.ExecuteReader();
            while (Lire.Read())
            {
                Console.WriteLine(" Numero : " + Lire.GetDouble("NumA") + " Nom Art : " + Lire.GetString("NomA") + " Prix d'achat : " + Lire.GetDouble("PrixAchat") + " Prix de vente : " + Lire.GetDouble("PrixVente"));
            }

            Lire.Close();

        }

        public static void ArtCoulPoidsX(Article Art)
        {
             List<Article> AllArticles = new List<Article>();

            cmd = new MySqlCommand(" Select NumA, NomA, PoidsA, CouleurA from article where (CouleurA = 'Rouge' and PoidsA > 500)   ", Connexion.Connect);

            Lire = cmd.ExecuteReader();
            Tab = new DataTable();

            Tab.Load(Lire);

            foreach (DataRow row in Tab.Rows)
            {
                AllArticles.Add(
                    new Article(
                        int.Parse(row["NumA"].ToString()),
                        row["NomA"].ToString(),
                        float.Parse(row["PoidsA"].ToString()),
                        row["CouleurA"].ToString()));
            }

            foreach (Article art in AllArticles)
                Console.WriteLine(art.toString1());

            Lire.Close();
        }

        public static void PoidsPaX()
        {

            cmd = new MySqlCommand(" Select NumA, NomA, PoidsA from article where (PoidsA >= 600) order by PoidsA asc ", Connexion.Connect);

            Lire = cmd.ExecuteReader();

            while(Lire.Read())
            {
                Console.WriteLine(" Numero : " + Lire.GetDouble("NumA") + " Nom Art : " + Lire.GetString("NomA") + " Poids Art : " + Lire.GetDouble("PoidsA"));
            }

            Lire.Close();

        }

        public static void PaSupX()
        {
            List<Article> AllArticles = new List<Article>();

            cmd = new MySqlCommand(" Select NumA, NomA, PrixAchat from article where PrixAchat > 100  ", Connexion.Connect);

            Lire = cmd.ExecuteReader();

            Tab = new DataTable();
            Tab.Load(Lire);

            foreach (DataRow row in Tab.Rows)
            {
                AllArticles.Add(
                    new Article(
                        int.Parse(row["NumA"].ToString()),
                        row["NomA"].ToString(),
                        float.Parse(row["PrixAchat"].ToString())
                       ));
            }

            foreach (Article art in AllArticles)
                Console.WriteLine(art.toString3());
            Lire.Close();
        }

        public static void MargeB()
        {

            cmd = new MySqlCommand(" Select NumA, PrixAchat, PrixVente, MargeB from article where PrixAchat > 100  ", Connexion.Connect);

            Lire = cmd.ExecuteReader();


                while (Lire.Read())
                {
                    Console.WriteLine(" Num : " + Lire.GetDouble("NumA") + " Prix Achat :  " + Lire.GetDouble("PrixAchat") + " Prix de Vente : " + Lire.GetDouble("PrixVente") + " Marge beneficiaire : " + Lire.GetDouble("MargeB"));
                }

            Lire.Close();
        }

        public static void MoyMaxMin()
        {
            cmd = new MySqlCommand(" Select avg(PoidsA), Max(PrixVente), Min(PrixAchat) from article where CouleurA != '' ", Connexion.Connect);

            Lire = cmd.ExecuteReader();

            while (Lire.Read())
                Console.WriteLine(" Moyenne Poids : " + Lire.GetDouble(0) + " | Max PV : " + Lire.GetDouble(1) + " | Min PA : " + Lire.GetDouble(2));

            Lire.Close();
        }

        public static void DiffCouleurArt()
        {
            cmd = new MySqlCommand(" Select CouleurA from article group by(CouleurA) ", Connexion.Connect);

            Lire = cmd.ExecuteReader();


                while (Lire.Read())
                    Console.WriteLine("  < " + Lire.GetString("CouleurA") + "> ");

            Lire.Close();
        }

        public static void MoyPV()
        {

            cmd = new MySqlCommand(" select avg(PrixVente) from article where PrixAchat >= 110 ", Connexion.Connect);

            int Rep = Convert.ToInt32(cmd.ExecuteScalar());
            
            Console.WriteLine(" Moyenne PV : " + Rep);
            
        }

        public static void SomPV()
        {
            cmd = new MySqlCommand(" Select sum(PrixVente) from article ", Connexion.Connect);

            int S = Convert.ToInt32(cmd.ExecuteScalar());

            if (S >= 0)
                Console.WriteLine(" La somme des Prix de ventes est : " + S);

        }

        public static void FrsCouleurX()
        {
            cmd = new MySqlCommand(" Select NumA, NomA, CouleurA, ArtF from article where CouleurA = @CouleurA ", Connexion.Connect);
            cmd.Parameters.AddWithValue("@CouleurA", "Noir");

            Lire = cmd.ExecuteReader();

            while (Lire.Read())
            {
                Console.WriteLine(" Num Article : " + Lire.GetDouble("NumA") + " | Couleur :  " + Lire.GetString("CouleurA") + " | Num fournisseur : " + Lire.GetDouble("ArtF"));
            }

            Lire.Close();

        }

        public static void MinPvCoulX()
        {
            MySqlCommand Cmd = new MySqlCommand(" Select min(PrixVente) from article where CouleurA = 'Blanc' ", Connexion.Connect);
            int Min = Convert.ToInt32(cmd.ExecuteScalar());

            if(Min > 0)
            cmd = new MySqlCommand(" Select NumA, NomA, CouleurA, PrixAchat, PrixVente from article where PrixVente > @Min", Connexion.Connect);
            cmd.Parameters.AddWithValue("@Min", Min);

            Lire = cmd.ExecuteReader();

            while (Lire.Read())
            {
                Console.WriteLine(" Num Article : " + Lire.GetDouble("NumA") + " | Couleur :  " + Lire.GetString("CouleurA") + " | Prix d'achat : " + Lire.GetDouble("PrixAchat") + " | Prix de vente : " + Lire.GetDouble("PrixVente"));
            }

            Lire.Close();
        }

        public static void GerantLocX()
        {
            cmd = new MySqlCommand(" Select GerantMag, LocMag, NumMag from magazin where LocMag = @LocMag ", Connexion.Connect);
            cmd.Parameters.AddWithValue("@LocMag", "Sfax");

            Lire = cmd.ExecuteReader();

            while(Lire.Read())
            {
                Console.WriteLine(" Numero : " + Lire.GetDouble("NumMag") + " | Nom Gerant : " + Lire.GetString("GerantMag") + " | Localisation : " + Lire.GetString("LocMag"));
            }

            Lire.Close();

        }

        public static void ArtPvSupX()
        {
            cmd = new MySqlCommand(" Select NumA, NomA, PrixAchat, PrixVente from article where Prixvente between 40 and 260  ", Connexion.Connect);

            Lire = cmd.ExecuteReader();
            while (Lire.Read())
            {
                Console.WriteLine(" Numero : " + Lire.GetDouble("NumA") + " Nom Art : " + Lire.GetString("NomA") + " Prix d'achat : " + Lire.GetDouble("PrixAchat") + " Prix de vente : " + Lire.GetDouble("PrixVente"));
            }

            Lire.Close();
        }

        public static void MagLocX()
        {
            cmd = new MySqlCommand(" Select GerantMag, LocMag, NumMag from magazin where LocMag != @LocMag ", Connexion.Connect);
            cmd.Parameters.AddWithValue("@LocMag", "Sousse");

            Lire = cmd.ExecuteReader();

            while (Lire.Read())
            {
                Console.WriteLine(" Numero : " + Lire.GetDouble("NumMag") + " | Nom Gerant : " + Lire.GetString("GerantMag") + " | Localisation : " + Lire.GetString("LocMag"));
            }

            Lire.Close();
        }

        public static void ArtPrixVCher()
        {
            MySqlCommand Cmd = new MySqlCommand(" Select Max(PrixVente) from article ", Connexion.Connect);
            int Max = Convert.ToInt32(Cmd.ExecuteScalar());

                
            cmd = new MySqlCommand(" Select Max(PrixVente), NumA, PrixVente, ArtF from article where PrixVente = @Max ", Connexion.Connect);
            cmd.Parameters.AddWithValue("@Max", Max);

            Lire = cmd.ExecuteReader();

            while (Lire.Read())
            {
                Console.WriteLine(" Num Article : " + Lire.GetDouble("NumA") + " | Prix vente :  " + Lire.GetString("PrixVente") + " | Num fournisseur : " + Lire.GetDouble("ArtF"));
            }

            Lire.Close();
        }
    }
}
