using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Personnage
{
    class PersonneView
    {
        static OleDbConnection db;
        static OleDbCommand cmd;
        static bool Connected = false;

        public static void ConnectTo()
        {
            string Link = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= C:\Users\kevin\Documents\vente.accdb";

            db = new OleDbConnection(Link);

            db.Open();
            Connected = true;

            Console.WriteLine("         -- Connected --   ");

        }

        public static void Show(Personne p)
        {
            Console.WriteLine(" Nom : " + p.Nom);
            Console.WriteLine(" Prenom : " + p.Prenom);
            Console.WriteLine(" Age : " + p.Age);
        }

        public static void Show(List<Personne> perso)
        {

            foreach (Personne art in perso)
                Show(perso);

        }


        public static void Ajouter()
        {
            ConnectTo();
            Personne a = new Personne();

            Console.Write(" Id : ");
            a.Id = int.Parse(Console.ReadLine());

            Console.Write(" Nom : ");
            a.Nom = Console.ReadLine();

            Console.Write(" Prenom : ");
            a.Prenom = Console.ReadLine();

            Console.Write(" Age  :  ");
            a.Age = int.Parse(Console.ReadLine());

            cmd = new OleDbCommand(" Insert into Personnne values (a.Id,a.Nom, a.Prenom, a.Age)", db);
            cmd.Parameters.AddWithValue("@ID", a.Id);
            cmd.Parameters.AddWithValue("@Nom", a.Nom);
            cmd.Parameters.AddWithValue("@Prenom", a.Prenom);
            cmd.Parameters.AddWithValue("@Date_Naiss", a.Age);

            cmd.ExecuteNonQuery();

        }

       
}

