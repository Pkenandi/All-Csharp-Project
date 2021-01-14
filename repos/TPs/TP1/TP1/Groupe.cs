using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Groupe
    {
        Etudiant[] Tab;
        int NbEtudiant;


        public Groupe()
        {

        }


        public Groupe(int Nb)
        {
            NbEtudiant = Nb;
            Tab = new Etudiant[NbEtudiant];

        }

        public void Saisir()
        {
            int i;

            Console.Write(" Nombre d'etudiant du groupe : ");
            NbEtudiant = int.Parse(Console.ReadLine());

            Tab = new Etudiant[NbEtudiant];
            for (i = 0; i < NbEtudiant; i++)
            {
                Console.Write(" \n\t  ETUDIANT " + (i + 1) + "\n");
                Tab[i] = new Etudiant();
                Tab[i].Saisir();

            }
        }

        public override string ToString()
        {
            string ChaineTotal = " Nbr Etudiant " + Tab.Length + "\n";
            for (int i = 0; i < Tab.Length; i++)
            {
                ChaineTotal += Tab[i];
            }
            return ChaineTotal;
        }

        public void Tri()
        {
            int annee, j;

            for (int i = 1; i < Tab.Length; i++)
            {
                annee = Tab[i].Datnaiss.Annee;
                j = i;
                while ((j > 0) && (Tab[j].Datnaiss.Annee > annee))
                {
                    Tab[j - 1] = Tab[j];
                    j--;
                }
                //Tab[j].Datnaiss.Annee = annee;
            }

        }

        public void Affichage()
        {
            Console.Write("\n\n ------------ \n");
            for (int i = 0; i < NbEtudiant; i++)
            {

                Tab[i].Afficher();
                Console.WriteLine("\t ------------ ");
            }
        }

        //Indexeur

        private Etudiant[] champ = new Etudiant[3];

        public Etudiant this[int index]
        {
            get
            {
                return champ[index];
            }
            set
            {
                champ[index] = value;
            }
        }


    }
}
