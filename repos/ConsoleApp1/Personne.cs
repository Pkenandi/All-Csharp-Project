using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Personne
    {
        protected string nom;
        protected string prenom;
        public Date naissance { get;set; }
        public Personne()
        { }
        public Personne(string nom,string prenom,Date d)
        {
            naissance = d;
            this.nom = nom;
            this.prenom = prenom;
        }

        /*Cette methode permet de recupérer la date de naissance saisie à partir de
         * la classe Date pour qu'elle devient la date de naissance de la personne*/
        public virtual void saisir(Date d)
        {
            naissance = d;
            Console.Write("Donner le nom et le prenom de la personne : ");
            nom = Console.ReadLine();
            prenom = Console.ReadLine();
        }

        /*Cette methodes permet de saisir la date de naissance de la personne à partir
         * de la classe Personne. Pas besoin de recuper une date saisie à partir de la
         Classe Date pour qu'elle devient la date de Naissance de la Personne*/
        public virtual void saisir()
        {
            naissance = new Date();
            naissance.saisir();
            Console.Write("Donner le nom et le prenom de la personne : ");
            nom = Console.ReadLine();
            prenom = Console.ReadLine();
        }

        public virtual void afficher()
        {
            Console.Write(nom + " " + prenom+" ");

            naissance.afficher();
        }
    }
   
}
