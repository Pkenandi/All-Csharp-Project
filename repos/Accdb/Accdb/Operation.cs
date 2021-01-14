using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Accdb
{
    class Operation
    {
        public static void Add()
        {
            int Id;
            string Nom;
            int Qts;
            int PrixU;
            string Date;

            Console.WriteLine(" Ajout d'un article !! \n");

            Console.Write(" ID : ");
            Id = int.Parse(Console.ReadLine());
            Console.Write(" Nom : ");
            Nom = Console.ReadLine();
            Console.Write(" Quantité : ");
            Qts = int.Parse(Console.ReadLine());
            Console.Write(" Prix Unitaire : ");
            PrixU = int.Parse(Console.ReadLine());
            Console.Write(" Date ( jj/mm/aaaa ) : ");
            Date = Console.ReadLine();

            Program.cmd = new OleDbCommand(" INSERT INTO Article values (Id,Nom,Qts,PrixU,Date)", Program.connexion);

            Program.cmd.Parameters.AddWithValue("@ID", Id); // @ID correspond a "@inventaire" chez toi ! 
                Program.cmd.Parameters.AddWithValue("@Nom", Nom);
                    Program.cmd.Parameters.AddWithValue("@Quantite", Qts);
                Program.cmd.Parameters.AddWithValue("@PU", PrixU);
            Program.cmd.Parameters.AddWithValue("@DateL", Date);

            Program.cmd.ExecuteNonQuery();
                Program.cmd.Parameters.Clear();


            Console.WriteLine(" Article ajouté avec succés !! ");

            Program.connexion.Close();

        }

        public static void Drop()
        {
            int Id;

            Console.WriteLine(" Donner l'ID de l'article a supprimer : ");
            Id = int.Parse(Console.ReadLine());

            Program.cmd = new OleDbCommand(" DELETE FROM Article where @ID = Id ", Program.connexion);
            Program.cmd.Parameters.AddWithValue("@ID", Id);
            Program.cmd.ExecuteNonQuery();

            Console.WriteLine(" L'article ID = " + Id + " a eté supprimer avec succés !! ");

            Program.connexion.Close();
        }

        public static void Update()
        {
            int CurId;
            int NewId;
            string NewNom;
            int NewQts;
            int NewPU;
            string NewDate;

            Console.Write(" Saisir l'ID de l'article a modifier : ");
            CurId = int.Parse(Console.ReadLine());

            Console.Write(" New ID : ");
            NewId = int.Parse(Console.ReadLine());
            Console.Write(" New Name : ");
            NewNom = Console.ReadLine();
            Console.Write(" New Qts : ");
            NewQts = int.Parse(Console.ReadLine());
            Console.Write(" New PU : ");
            NewPU = int.Parse(Console.ReadLine());
            Console.Write(" New Date : ");
            NewDate = Console.ReadLine();

            Program.cmd = new OleDbCommand(" UPDATE Article set NewID= @ID  ,NewNom= @Nom , NewQts = @Quantite , NewPU = @PU, NewDate = @DateL  where @ID = CurId", Program.connexion);

            Program.cmd.Parameters.AddWithValue("@ID", NewId);
            Program.cmd.Parameters.AddWithValue("@Nom", NewNom);
            Program.cmd.Parameters.AddWithValue("@Quantite", NewQts);
            Program.cmd.Parameters.AddWithValue("@PU", NewPU);
            Program.cmd.Parameters.AddWithValue("@DateL", NewDate);

            Program.cmd.ExecuteNonQuery();
            Program.cmd.Parameters.Clear();

        }

        public static int Display()
        {
            Console.WriteLine(" Affichage des article !! ");
            Program.cmd = new OleDbCommand(" SELECT count(*) from Article ", Program.connexion);

            int n = (int)Program.cmd.ExecuteScalar();

            Program.connexion.Close();

            return n;

        }

    }
}
