using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GestionFiles
{
    class ArticleDAL
    {
        static Database db;
        
        public static void ConnectTo(Database Db)
        {

            db = Db;
            Console.WriteLine("         Connected       ");

        }

        public static void Add(Article a)
        {

            //db.LesArticles.Add(a);
            //db.SaveArticlesToFile();

            bool Exist = false;

            foreach( Article art in db.LesArticles)
            {
                if( art.Reference.Equals(a.Reference))
                {
                    Exist = true;
                    Console.WriteLine(" Cette reference existe déja !! \n Voulez-vous mettre a jour l'article ? N/O \n ==>  : ");
                    string Reponse = Console.ReadLine();

                    if( Reponse.Equals("O"))
                    {

                        Update(a.Reference, a);

                    }else
                    {
                        break;
                    }
                }
            }

            if( Exist.Equals(false))
            {
                db.LesArticles.Add(a);
                
            }
            db.Dispose();
        }

        public static void Delete(int Ref)
        {
            bool Exist = false;

            foreach(Article art in db.LesArticles )
            {
                if(art.Reference.Equals(Ref))
                {
                    Exist = true;
                    db.LesArticles.Remove(art);
                    db.SaveArticlesToFile();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(" L'article : < " + art.Reference + " ,  " + art.Designation + " , " + art.Prix + " > a eté supprimé ! ");
                    break;
                }
                
            }

            if (Exist == false)
            {
                Console.WriteLine(" This reference doesn't exist in Database ");
            }

        }

     
        public static void Update(int Ref, Article a)
        {
            bool Exist = false;

            foreach (Article art in db.LesArticles)
            {

                if (art.Reference.Equals(Ref))
                {
                    Exist = true;

                    art.Reference = a.Reference;
                    art.Prix = a.Prix;
                    art.Designation = a.Designation;
                   
                    db.SaveArticlesToFile();
                    break;
                }
                
                
            }

            if( Exist == false )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Cette reference n'existe pas dans la base de données !! ");
            }
        }

        public static Article SelectByRef(int Ref)
        {
            foreach (Article art in db.LesArticles)
            {
                if (art.Reference == Ref)
                {
                    return art;
                }

            }
            return null;
        }

        public static List<Article> SelectAll()
        {

            return db.LesArticles;
        }

    }

}

