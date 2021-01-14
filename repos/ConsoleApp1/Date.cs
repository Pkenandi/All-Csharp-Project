using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Date
    {
        protected int jour;
        protected int mois;
        protected int annee;
        public int age
        {
            get
            {
                return DateTime.Now.Year - annee;
            }
        }
        public Date(): this(0,0,0)
        {

        }
        public Date(int jour,int mois,int annee)
        {
            this.jour = jour;
            this.mois = mois;
            this.annee = annee;
        }
        public  void saisir()
        {
            Console.Write("Donnez une date : ");
            string j = Console.ReadLine();
            this.jour = int.Parse(j);
            string m = Console.ReadLine();
            mois = Convert.ToInt32(m);
            string a = Console.ReadLine();
            this.annee = int.Parse(a);
        }
        public void afficher()
        {
            Console.Write(this.jour + "/" + this.mois + "/" + this.annee + " ");
        }
        public bool comparaison(Date d2)
        {
            return (this.jour == d2.jour && this.mois == d2.mois && this.annee == d2.annee);
        }
    }
    
}
