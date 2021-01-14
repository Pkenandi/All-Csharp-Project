using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class ArticleView
    {
        public static void Show(Article a)
        {
           
            Console.WriteLine("  |   " + a.Reference + "  |  " + a.Designation + "\t  | " + a.Prix +"     | " );

        }

        public static void Show(List<Article> LesArticles )
        {

            foreach (Article art in LesArticles)
                Show(art);

        }

        public static Article GetArticleFormUser()
        {
            Article a = new Article();

            Console.Write(" Reference : ");
            a.Reference = int.Parse(Console.ReadLine());

            Console.Write(" Designation : ");
            a.Designation = Console.ReadLine();

            Console.Write(" Prix :  ");
            a.Prix = int.Parse(Console.ReadLine());

            return a;
        }

        public static void CommandeAjouter()
        {
            ArticleDAL.Add(GetArticleFormUser());

        }

        public static void CommandeSupprimer()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" Reference de l'article a supprimer : ");
            int Ref = int.Parse(Console.ReadLine());

            ArticleDAL.Delete(Ref);

        }

        public static void CommandeModifier()
        {
            Console.Write(" Reference de l'article à modifier : ");
            int Ref = int.Parse(Console.ReadLine());

            Console.WriteLine("\n < Nouvelles Données > ");
            ArticleDAL.Update(Ref, GetArticleFormUser());

        }

        public static void CommandeChercherParReference()
        {
            Article Art = new Article();

            Console.Write(" Reference de l'article : ");
            int Ref = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Art = ArticleDAL.SelectByRef(Ref);

            if(Art != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("   _________________________________");
                Console.WriteLine("  | Ref  |   Designation  |  Prix   |");
                Console.WriteLine("  |------|----------------|---------|");
                Show(Art);
            }else
            {
                Console.WriteLine(" Reference non valide !!! ");
            }

        }

        public static void CommandeAfficherTout()
        {

            List<Article> list = ArticleDAL.SelectAll();

            if (list.Count != 0)
            {
                Console.WriteLine("   _________________________________");
                Console.WriteLine("  | Ref  |   Designation  |  Prix   |");
                Console.WriteLine("  |------|----------------|---------|");
                Show(list);
            }
            else
                Console.WriteLine(" La base de données est vide !! ");

        }

        public static void Menu()
        {
            string Link = @"C:\Users\kevin\Documents\vente.accdb";

            bool Quit = false;


            ArticleDAL.ConnectTo(Link);
            

            do
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.White;

                int Choice;
                Console.WriteLine("\n");
                Console.WriteLine("           - Main -                             ");
                Console.WriteLine(" -------------------------------");
                Console.WriteLine(" 1. Afficher tout                            ");
                Console.WriteLine(" 2. Ajouter un Article                   ");
                Console.WriteLine(" 3. Supprimer un Article             ");
                Console.WriteLine(" 4. Modifier un Article                 ");
                Console.WriteLine(" 5. Rechercher par Reference    ");
                Console.WriteLine(" 6. Quitter                                     ");
                Console.WriteLine(" 7. Vider la console                       ");
                Console.WriteLine("--------------------------------");
                Console.Write(" ==> : ");
                Choice = int.Parse(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine();
                            CommandeAfficherTout();
                            Console.WriteLine("\n");
                            break;
                        }

                    case 2:
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine();
                            CommandeAjouter();
                            Console.WriteLine("\n");
                            break;
                        }

                    case 3:
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine();
                            CommandeSupprimer();
                            Console.WriteLine("\n");
                            break;
                        }

                    case 4:
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine();
                            CommandeModifier();
                            Console.WriteLine("\n");
                            break;
                        }

                    case 5:
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine();
                            CommandeChercherParReference();
                            Console.WriteLine("\n");
                            break;
                        }

                    case 6:
                        Quit = true;
                        break;

                    case 7:
                        {
                            Console.Clear();
                            break;
                        }
                }

            } while (Quit != true);

        }
    }
}
