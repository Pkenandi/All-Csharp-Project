using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Groupe
    {
        private int nbr;
        private Etudiant[] tab ;
        public Etudiant this[int index]
        {
            get { return tab[index]; }
            set { tab[index] = value; }
        }

        public Groupe() { tab = null; }
        public Groupe(int nbr)
        {
            this.nbr = nbr;
            tab = new Etudiant[nbr];
        }
        public void saisirEtudiant()
        {
            for(int i=0;i<nbr;i++)
            {
                Console.WriteLine("Etudiant numero " + i);
                tab[i] = new Etudiant();
                tab[i].saisir();
            }
        }
        public void afficherEtudiant()
        {
            foreach(Etudiant e in tab)
            {
                e.afficher();
            }
        }
        public void Trier()
        {
            Etudiant StudentTemp;
            int i = 0;
            while (i <= nbr - 2)
            {
                for (int j = i + 1; j < nbr; j++)
                {
                    if (tab[j].naissance.age < tab[i].naissance.age)
                    {
                        StudentTemp = tab[j];
                        tab[j] = tab[i];
                        tab[i] = StudentTemp;
                    }
                }
                i++;
            }

        }

    }
}
