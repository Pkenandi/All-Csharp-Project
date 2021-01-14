using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GestionFiles
{
    class ArticleView
    {
        // Affichage des informations concernant un article
        public static void Show(Article a)
        {
            Console.WriteLine("  |   " + a.Reference + "  |  " + a.Designation + "\t  | " + a.Prix + "      | ");
            Console.WriteLine("  |______|________________|__________|");

        }

        // Affichage des informations concernant une liste d’articles
        public static void Show(List<Article> LesArticles)
        {
            foreach (Article art in LesArticles)
                Show(art);

        }

        // Saisie des données d’un article à partir de l’utilisateur
        public static Article GetArticleFromUser()
        {
            Article article = new Article();

            Console.Write(" Reference : ");
            article.Reference = int.Parse(Console.ReadLine());
            Console.Write(" Designation : ");
            article.Designation = Console.ReadLine();
            Console.Write(" Prix : ");
            article.Prix = int.Parse(Console.ReadLine());

            return article;
        }
        
        // Saisie des données d’un article et son ajout à la base de données
        public static void CommandeAjouter()
        {
            Article art = new Article();

            art = GetArticleFromUser();

            ArticleDAL.Add(art);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Article ajouter avec succés !! ");

        }

        // Saisie de la ref de l’article à supprimer puis sa suppression de la base
        public static void CommandeSupprimer()
        {
            
            Console.Write(" Donner la reference de l'article a supprimer : ");
            int supRef = int.Parse(Console.ReadLine());

            ArticleDAL.Delete(supRef);
            

        }

        // Saisie de la ref de l’article à modifier puis saisie des nouvelles données suivi de la mise à  jour
        public static void CommandeModifier()
        {
    

            Console.Write(" Donner la reference de l'article a modifier : ");
            int upRef = int.Parse(Console.ReadLine());

            ArticleDAL.Update(upRef, GetArticleFromUser());

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Mise à jour effectuée avec succés ! ");

        }

        // Saisie de la ref de l’article à recherché puis affichage du résultat
        public static void CommandeChercherParReference()
        { 
           
            Console.Write(" Saisir la reference de l'article a afficher : ");
            int seachRef = int.Parse(Console.ReadLine());

            Article art = ArticleDAL.SelectByRef(seachRef);

            
           if( art != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("   __________________________________");
                Console.WriteLine("  | Ref  |   Designation  |  Prix    |");
                Console.WriteLine("  |------|----------------|----------|");
                Show(art);
            }else
            {
                Console.WriteLine(" This reference doesn't exist !! ");
            }

        }

        // Affichage de la liste des articles de la base de données
        public static void CommandeAfficherTout()
        {

            List<Article> Liste = ArticleDAL.SelectAll();

            if(Liste.Count != 0)
            {
                Console.WriteLine("   __________________________________");
                Console.WriteLine("  | Ref  |   Designation  |  Prix    |");
                Console.WriteLine("  |------|----------------|----------|");
                Show(Liste);
            }else
            {
                Console.WriteLine(" Database is ampty !! ");
            }

        }

        // Un menu appelant les commandes ci-dessus
        public static int Menu()
        {
            int choice;
            bool leave = true;
       
            Database db = new Database("Articles.txt"); // Creation du fichier "Article.txt"
            ArticleDAL.ConnectTo(db); // Connexion a la base des données ;

            while (leave == true)
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.White;

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
                choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine();
                            CommandeAfficherTout();
                            Console.WriteLine("\n");
                            break;

                        }

                    case 2:
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
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
                        {
                            leave = false;
                            break;

                        }

                    case 7:
                        {
                            Console.Clear();
                            break;
                        }
                }

            }

            return 0;

        }

    }
}