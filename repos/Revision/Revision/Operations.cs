using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Revision
{
    class Operations
    {
        public static MySqlCommand cmd;
        static Personne P = new Personne();
        static Animal A = new Animal();

        public static void AjoutPersonne()
        {
            Console.Write(" Id : ");
            P.ID = int.Parse(Console.ReadLine());
            Console.Write(" Nom : ");
            P.nom = Console.ReadLine();
            Console.Write(" Prenom : ");
            P.prenom = Console.ReadLine();
            Console.Write(" Age : ");
            P.age = int.Parse(Console.ReadLine());

            cmd = new MySqlCommand(" Insert into personne values (@ID,@Nom,@Prenom,@Age) ", Connexion.Connect);
            cmd.Parameters.AddWithValue("@ID", P.ID);
            cmd.Parameters.AddWithValue("@Nom", P.nom);
            cmd.Parameters.AddWithValue("@Prenom", P.prenom);
            cmd.Parameters.AddWithValue("@Age", P.age);

            cmd.ExecuteNonQuery();

            Console.WriteLine(" Ajout effectuer !! ");

        }

        public static void AjoutAnimal()
        {
            Console.Write(" Code  : ");
            A.Code = int.Parse(Console.ReadLine());
            Console.Write(" Nom : ");
            A.Nom = Console.ReadLine();
            Console.Write(" Race : ");
            A.Race = Console.ReadLine();
            Console.Write(" Id Proprio : ");
            A.IdP = int.Parse(Console.ReadLine());

            cmd = new MySqlCommand(" Insert into animal values (@Code,@NomA,@Race,@IdP) ", Connexion.Connect);
            cmd.Parameters.AddWithValue("@Code", A.Code);
            cmd.Parameters.AddWithValue("@NomA", A.Nom);
            cmd.Parameters.AddWithValue("@Race", A.Race);
            cmd.Parameters.AddWithValue("@IdP", A.IdP);

            cmd.ExecuteNonQuery();

            Console.WriteLine(" Ajout effectuer !! ");

        }

        public static void ShowAllAnimals()
        {
            cmd = new MySqlCommand(" Select * from animal ", Connexion.Connect);

            MySqlDataReader Lire = cmd.ExecuteReader();

            while(Lire.Read())
            {
                Console.WriteLine(" Code : " + Lire.GetDouble("Code") + " Nom : " + Lire.GetString("NomA") + " Race : " + Lire.GetString("Race") + " Id Proprio : " + Lire.GetDouble("IdP"));
            }

            Lire.Close();
        }

        public static void ShowAllPersons()
        {
            cmd = new MySqlCommand(" Select * from personne ", Connexion.Connect);

            MySqlDataReader Lire = cmd.ExecuteReader();

            while (Lire.Read())
            {
                Console.WriteLine(" ID : " + Lire.GetDouble("ID") + " Nom : " + Lire.GetString("Nom") + " Prenom : " + Lire.GetString("Prenom") + " Age : " + Lire.GetDouble("Age"));
            }

            Lire.Close();
        }

        public static void UpdateAnimal()
        {
            Console.Write(" Saisir le code de l'animal : ");
            int Code = int.Parse(Console.ReadLine());

            MySqlCommand Try = new MySqlCommand(" Select (Code) from animal where Code = @Code", Connexion.Connect);
            Try.Parameters.AddWithValue("@Code", Code);

            int rep = Convert.ToInt32(cmd.ExecuteScalar());

            if(Code == rep)
            {
                Console.Write("(New) Code  : ");
                A.Code = int.Parse(Console.ReadLine());
                Console.Write("(New) Nom : ");
                A.Nom = Console.ReadLine();
                Console.Write("(New) Race : ");
                A.Race = Console.ReadLine();
                Console.Write("(New) Id Proprio : ");
                A.IdP = int.Parse(Console.ReadLine());

                cmd = new MySqlCommand(" Update animal set Code = @A.Code, NomA = @A.Nom, Race = @A.Race", Connexion.Connect);
                cmd.Parameters.AddWithValue("@A.Code", A.Code);
                cmd.Parameters.AddWithValue("@A.Nom", A.Nom);
                cmd.Parameters.AddWithValue("@A.Race", A.Race);

                cmd.ExecuteNonQuery();

                Console.WriteLine(" Modif effectuée !! ");

            }else
            {
                Console.WriteLine(" Aucun animal n'existe sous le code <" + Code + ">  ");
            }
        }
    }
}
