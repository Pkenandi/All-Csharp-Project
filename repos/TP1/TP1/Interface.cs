using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Interface
    {
        public int Menu()
        { 
            int choix;
            string ch;

            Date d = new Date();
            Date d1 = new Date();
            Date rep = new Date();
            Personne P = new Personne();
            Etudiant E = new Etudiant();
            Groupe G = new Groupe();


                    while (true)
                    {
                        Console.WriteLine("\n\t _____________________");
                        Console.WriteLine("\t 1. Date de naissance ");
                        Console.WriteLine("\t 2. Personne ");
                        Console.WriteLine("\t 3. Etudiant ");
                        Console.WriteLine("\t 4. Groupe Etudiant ");
                        Console.WriteLine("\t 5. Quitter ");
                        Console.WriteLine("\t _____________________");
                        Console.Write(" ==> :  ");
                        choix = int.Parse(ch = Console.ReadLine());

                        switch (choix)
                        {
                            case 1:
                                {
                                    int ds = 0;

                                    while (ds >= 0 && ds != 3)
                                    {
                                        Console.WriteLine("\n \t \" DATE DE NAISSANCE \"  ");

                                        Console.WriteLine("\t _____________________________");
                                        Console.WriteLine("\t  1. Saisie simple et affichage ");
                                        Console.WriteLine("\t  2. Saisie et comparaison ");
                                        Console.WriteLine("\t  3. Retour au menu ");
                                        Console.WriteLine("\t _____________________________");
                                        Console.Write(" ==> : ");
                                        ds = int.Parse(Console.ReadLine());


                                        if (ds == 1)
                                        {
                                            d.Saisir();

                                            Console.Write("\n La date de naissance est (jj/mm/yyyy) : ");
                                            d.Afficher();
                                        }
                                        else if (ds == 2)
                                        {
                                            Console.WriteLine(" Saisir la premiere date : ");
                                            d.Saisir();
                                            Console.WriteLine();
                                            Console.WriteLine(" Saisir la deuxieme date : ");
                                            d1.Saisir();

                                            Console.Write(" La premiere date est (jj/mm/yyyy) : ");
                                            d.Afficher();
                                            Console.Write(" La deuxieme date est (jj/mm/yyyy) : ");
                                            d1.Afficher();
                                            Console.WriteLine();

                                            rep.ComperDate(d, d1);

                                        }
                                        else
                                        {
                                            break;
                                        }

                                    }


                                    break;
                                }

                            case 2:
                                {
                                    Console.WriteLine("\n\t  \" PERSONNE \"  \n ");
                                    P.Saisir();

                                    Console.WriteLine();
                                    P.Afficher();
                                    Console.WriteLine(" --------------------------------- ");

                                    break;
                                }

                            case 3:
                                {
                                    Console.WriteLine("\n\t  \" ETUDIANT  \"  \n");
                                    E.Saisir();

                                    Console.WriteLine();
                                    E.Afficher();
                                    Console.WriteLine(" --------------------------------- ");

                                    break;
                                }

                            case 4:
                                {

                                    Console.WriteLine("\n\t \" GROUPE ETUDIANT  \"  \n ");

                                    int ds = 0;

                                    while (ds >= 0 && ds != 3)
                                    {
                                        Console.WriteLine("\n \t \" DATE DE NAISSANCE \"  ");

                                        Console.WriteLine("\t _____________________________");
                                        Console.WriteLine("\t  1. Remplissage et affichage ");
                                        Console.WriteLine("\t  2. Remplissage et tri ");
                                        Console.WriteLine("\t  3. Retour au menu ");
                                        Console.WriteLine("\t _____________________________");
                                        Console.Write(" ==> : ");
                                        ds = int.Parse(Console.ReadLine());


                                        if (ds == 1)
                                        {
                                            G.Saisir();

                                            G.Affichage();
                                        }
                                        else if (ds == 2)
                                        {
                                            G.Saisir();
                                            Console.WriteLine();

                                            G.Tri();
                                            Console.WriteLine();

                                            G.Affichage();

                                        }
                                        else
                                        {
                                            break;
                                        }

                                    }


                                    break;
                                }

                            case 5:
                                {
                                    return 0;

                                }

                        default: break;

                        }


                    }

            return 0;

            }
    }
}
