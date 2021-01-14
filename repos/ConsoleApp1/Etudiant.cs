using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        public class Etudiant:Personne
    {
        private string etab;
        private int td;
        public Etudiant()
        { }
        public Etudiant(string nom, string prenom,Date d, string etab,int td): base(nom, prenom,d )
        {
            this.etab = etab;
            this.td = td;
        }
        public override void saisir()
        {
            base.saisir();
            Console.Write("Donnez votre etablissement et le numero de votre TD : ");
            etab = Console.ReadLine();
            string t = Console.ReadLine();
            td = Convert.ToInt32(t);
        }
        public override void afficher()
        {
            base.afficher();
            Console.WriteLine(" "+etab+" "+"TD "+td+"\n");
        }
    }
}
