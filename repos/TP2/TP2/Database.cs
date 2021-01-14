using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GestionFiles
{
    class Database : IDisposable
    {
        public List<Article> LesArticles;
        public string DbFileName;

        public Database(string FileName)
        {
            LesArticles = new List<Article>();
            DbFileName = FileName;
            GetArticlesFromfile(FileName);
        }

        public void GetArticlesFromfile(string FileName)
        {
            string line;
            int CurReference;
            string CurDesignation;
            float CurPrix;
            string[] ArticleFields;
            char[] Separator = new char[] { ',' };

            try
            {

                System.IO.StreamReader file = new System.IO.StreamReader(FileName);
                     
                while ((line = file.ReadLine()) != null)
                {
                    ArticleFields = line.Split(new char[] { ',' });
                    CurReference = Int32.Parse(ArticleFields[0].Trim());
                    CurDesignation = ArticleFields[1].Trim();
                    CurPrix = Single.Parse(ArticleFields[2].Trim());
                    LesArticles.Add(new Article(CurReference, CurDesignation, CurPrix));
                }

                file.Close();

            }
            catch (FileNotFoundException e)
            {
                File.Create(e.FileName);
            }
            
        }

        public void SaveArticlesToFile()
        {
            string DataBaseContent = "";
            foreach (Article a in LesArticles)
                DataBaseContent += a.Reference.ToString() + "," + a.Designation + "," +
                a.Prix.ToString() + "\n";
            File.WriteAllText(DbFileName, DataBaseContent);
        }

        public void Dispose()
        {
            SaveArticlesToFile();
        }
    }
}
