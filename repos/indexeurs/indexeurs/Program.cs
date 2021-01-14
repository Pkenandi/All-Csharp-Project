using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexeurs
{
    class Language
    {
        // membres de la classe
        private string[] str = new string[10];
        // déclaration de l'indexeur
        public string this[int index]
        {
            get
            {
                return str[index];
            }
            set
            {
                str[index] = value;
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Language lang = new Language();

            lang[0] = "C#";
            lang[1] = "C++";
            lang[2] = "Java";
            lang[3] = "PHP";
            lang[4] = "Python";

            Console.WriteLine(lang[2]);

            for (int i = 0; i < 10; i++)
                Console.WriteLine(lang[i]);
        }
    }
}
