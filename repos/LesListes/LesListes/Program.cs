using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LesListes
{
    class Liste
    {
        int NumTel;
        List<int> Numero;

        public Liste()
        {
            Numero = new List<int>();
        }
        public Liste(int N)
        {
            NumTel = N;
        }

        public void ajouter()
        {
            Console.Write(" Saisir le numero telephonique : ");
            NumTel = int.Parse(Console.ReadLine());
            Numero.Add(NumTel);

        }

        public void Afficher()
        {
            Console.Write(" Le numero de telephone est : ");
            foreach (int i in Numero)
            {
                Console.WriteLine(i);
            }
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            Liste L = new Liste();

            L.ajouter();

            L.Afficher();
            

        }
    }
}
