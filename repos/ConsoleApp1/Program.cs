using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("*****Saisie de la Date de naissance******\n");
            Date g=new Date();
            g.saisir();
            Console.WriteLine("*****Affichage de la Date de Naissance***** \n");
            g.afficher();
            Console.WriteLine("\n");            

            Console.WriteLine("*****Saisie d'une Personne*****");
            Personne p = new Personne(); Console.WriteLine("\n");
            p.saisir(g);
            Console.WriteLine("*****Affichage de la Personne*****\n");
            p.afficher(); Console.WriteLine("\n");


            Console.WriteLine("*****Saisie d'un Etudiant*****\n");
            Etudiant e = new Etudiant();
            e.saisir();
            Console.WriteLine("*****Affichage de l'Etudiant*****\n");
            e.afficher(); Console.WriteLine("\n");


            Console.WriteLine("*****Saisie d'un Groupe d'etudiant *****\n");
            Groupe gr = new Groupe(2);
            gr.saisirEtudiant();
            Console.WriteLine("******Affichage du Groupe d'etudiant*****\n");
            gr.afficherEtudiant();
            gr.Trier();
            Console.WriteLine("*****Affichage du Groupe d'etudiant trier selon leur age*****");
            gr.afficherEtudiant();
            Console.WriteLine("*****Affichage d'un etudiant à travers l'indexeur*****\n");
            gr[1].afficher(); //exemple d'utilisation de l'indexeur

        }
    }
}
