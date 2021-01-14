using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace vente
{
    class Operation
    {
        public static MySqlCommand cmd;

        // Ajout Client, Produit, Commande, Facture, PC

        public static void AjoutClient()
        {

                Client c = new Client();

                Console.Write(" Code Client :  ");
                c.CodC = int.Parse(Console.ReadLine());
                Console.Write(" Nom Client : ");
                c.NomC = Console.ReadLine();
                Console.Write(" Credits :  ");
                c.CreditC = float.Parse(Console.ReadLine());
                Console.Write(" Adresse Client : ");
                c.AdrC = Console.ReadLine();
                Console.Write(" Chiffre d'affaire : ");
                c.CA = float.Parse(Console.ReadLine());

                cmd = new MySqlCommand(" Insert into client values (@CodC, @Nomc, @CreditC, @AdrC, @CA)", Connexion.Cnn);
                cmd.Parameters.AddWithValue("@CodC", c.CodC);
                cmd.Parameters.AddWithValue("@Nomc", c.NomC);
                cmd.Parameters.AddWithValue("@CreditC", c.CreditC);
                cmd.Parameters.AddWithValue("@AdrC", c.AdrC);
                cmd.Parameters.AddWithValue("@CA", c.CA);

                cmd.ExecuteNonQuery();

                Console.WriteLine(" Ajout reussie ! ");
            
        }

        public static void AjoutProduit()
        {
            Produit P = new Produit();

            Console.Write(" Code Produit :  ");
            P.CodP = int.Parse(Console.ReadLine());
            Console.Write(" Libelé du Produit : ");
            P.Lib = Console.ReadLine();
            Console.Write(" Prix U :  ");
            P.PU = float.Parse(Console.ReadLine());
            Console.Write(" Quantité :  ");
            P.Qtes = int.Parse(Console.ReadLine());
            Console.Write(" Seuil du produit : ");
            P.Seuil = Console.ReadLine();
            

            cmd = new MySqlCommand(" Insert into produit values (@codP, @Lib , @PU, @Qtes, @Seuil)", Connexion.Cnn);
            cmd.Parameters.AddWithValue("@codP", P.CodP);
            cmd.Parameters.AddWithValue("@Lib", P.Lib);
            cmd.Parameters.AddWithValue("@PU", P.PU);
            cmd.Parameters.AddWithValue("@Qtes", P.Qtes);
            cmd.Parameters.AddWithValue("@Seuil", P.Seuil);

            cmd.ExecuteNonQuery();

            Console.WriteLine(" Ajout reussie ! ");
        }

        public static void AjoutCommande()
        {
            Commande C = new Commande();

            Console.Write(" Num commande :  ");
            C.NumC = int.Parse(Console.ReadLine());
            Console.Write(" Date commande : ");
            C.DatC = Console.ReadLine();
            Console.Write(" Code client :  ");
            C.CodC = int.Parse(Console.ReadLine());

            cmd = new MySqlCommand(" Insert into commande values (@NumC,@Datc,@CodC)", Connexion.Cnn);
            cmd.Parameters.AddWithValue("@NumC", C.NumC);
            cmd.Parameters.AddWithValue("@Datc", C.DatC);
            cmd.Parameters.AddWithValue("@CodC", C.CodC);

            cmd.ExecuteNonQuery();

            Console.WriteLine(" Ajout Effectuer !! ");

        }

        public static void AjoutPC()
        {
            PC P = new PC();
            
            Console.Write(" Code Produit : ");
            P.CodP = int.Parse(Console.ReadLine());
            Console.Write(" Numero commande : ");
            P.NumC = int.Parse(Console.ReadLine());
            Console.Write(" Quantité commandée : ");
            P.Qtec = int.Parse(Console.ReadLine());

            cmd = new MySqlCommand(" Insert into PC values (@CodP, @NumC, @QteC)", Connexion.Cnn);
            cmd.Parameters.AddWithValue("@CodP", P.CodP);
            cmd.Parameters.AddWithValue("@NumC", P.NumC);
            cmd.Parameters.AddWithValue("@QteC",P.Qtec);

            cmd.ExecuteNonQuery();

            Console.WriteLine(" Ajout effectuer !! ");

        }

        //Question 1 : 

        public static int Count()
        {

            cmd = new MySqlCommand("SELECT COUNT(*) FROM client ", Connexion.Cnn);

            int nbr = Convert.ToInt32(cmd.ExecuteScalar());


            return (nbr);

        }

        //Question 2 :

        public static void SUM()
        {
            Client C = new Client();
            MySqlDataReader resultat;

            cmd = new MySqlCommand(" Select sum(CA) from client ", Connexion.Cnn);
            cmd.Parameters.AddWithValue("@CA", C.CA);

            resultat = cmd.ExecuteReader();

            while(resultat.Read())
                    Console.WriteLine(" La somme des chiffre d'affaire est " + resultat.GetDouble(0));

            resultat.Close();
        }

        // Question 3 : 

        public static void Moy()
        {
            MySqlDataReader res;
            Produit P = new Produit();

            cmd = new MySqlCommand(" Select avg(PU) from produit ", Connexion.Cnn);
            cmd.Parameters.AddWithValue("@PU", P.PU);

            res = cmd.ExecuteReader();

            while (res.Read())
                Console.WriteLine(" La moyenne des PU est " + res.GetDouble(0));

            res.Close();
            
        }

        // Question 4 :

        public static void MinMax()
        {
            Produit P = new Produit();

            cmd = new MySqlCommand(" Select max(Qtes) from produit ", Connexion.Cnn);
            MySqlCommand Cmd = new MySqlCommand(" Select min(Qtes) from produit  ", Connexion.Cnn);

            int Max = Convert.ToInt32(cmd.ExecuteScalar());
            int Min = Convert.ToInt32(Cmd.ExecuteScalar());

            Console.WriteLine(" Quantité Max : " + Max + " \n Quantité Min : " + Min);
        }

        // Question 5 : 

        public static void Date()
        {
            Commande C = new Commande();

            cmd = new MySqlCommand(" select max(Datc) from commande where CodC = 1250 ", Connexion.Cnn);
            cmd.Parameters.AddWithValue("@Datc", C.DatC);
            cmd.Parameters.AddWithValue("@CodC", C.CodC);

            string Date = Convert.ToString(cmd.ExecuteScalar());

            if (Date != "")
            {
                Console.WriteLine(" Le client numero 1250 est passé sa derniere commande le " + Date);
            }
            else
                Console.WriteLine(" Le client 1250 n'existe pas !! ");
        }

        // Question 6 :

        public static int NombreCommande()
        {
            Commande C = new Commande();

            cmd = new MySqlCommand(" Select count(distinct (CodC)) from commande ", Connexion.Cnn);
            cmd.Parameters.AddWithValue("@CodC", C.CodC);

            int Nbr = Convert.ToInt32(cmd.ExecuteScalar());

            return Nbr;
        }

        // --- Application 2 ---

        // Question 1

        public static void SumQtes()
        {
            PC P = new PC();
            MySqlDataReader Lire;

            cmd = new MySqlCommand(" Select sum(QteC), CodP from PC group by (CodP)", Connexion.Cnn);
            cmd.Parameters.AddWithValue("@QteC", P.Qtec);
            cmd.Parameters.AddWithValue("@CodP", P.CodP);


            Lire = cmd.ExecuteReader();
            int ctr = 1;

            while(Lire.Read())
            {
                Console.WriteLine(" Produit <" + ctr +">  : " + Lire.GetDouble(0));
                ctr++;
            }

            Lire.Close();
        }

        // Question 2 :

        public static void NbrArticleCommande()
        {
            PC P = new PC();
            int ctr = 1;

            cmd = new MySqlCommand(" Select count(CodP) from PC group by (CodP) ", Connexion.Cnn);
            cmd.Parameters.AddWithValue("@CodP", P.CodP);

            MySqlDataReader Lire = cmd.ExecuteReader();

            while(Lire.Read())
            {
                Console.WriteLine(" L'article <" + ctr +"> a etait commander " + Lire.GetDouble(0) + " fois ");
                ctr++;
            }

            Lire.Close();
        }

        public static void DeleteClient()
        {
            Client C = new Client();

            Console.Write(" Donner le code du client a supprimer : ");
            int code = int.Parse(Console.ReadLine());

            cmd = new MySqlCommand(" delete from client where CodC = ?", Connexion.Cnn);
            MySqlParameter P = new MySqlParameter("CodC", code);
            cmd.Parameters.Add(P);

            cmd.ExecuteNonQuery();

            Console.WriteLine(" Le client <" + code + "> a etait supprimer !! ");

        }

        public static void Update()
        {
            Client C = new Client();

            Console.Write(" Saisir le code : ");
            int code = int.Parse(Console.ReadLine());

            cmd = new MySqlCommand(" update client set CodC = 100, Nomc = 'Prince', CreditC = 7500, AdrC = 'Sousse', CA = 5500 where CodC = 6", Connexion.Cnn);
            cmd.Parameters.AddWithValue("@CodC", C.CodC);
            cmd.Parameters.AddWithValue("@Nomc", C.NomC);
            cmd.Parameters.AddWithValue("@CreditC", C.CreditC);
            cmd.Parameters.AddWithValue("@AdrC", C.AdrC);
            cmd.Parameters.AddWithValue("@CA", C.CA);

            cmd.ExecuteNonQuery();

            Console.WriteLine(" Modification effectuée !  ");
        }

    }
}
