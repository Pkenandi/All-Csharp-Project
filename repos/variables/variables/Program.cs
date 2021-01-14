using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,s;
            string i;

            Console.WriteLine(" Saisir la valeur de a : ");
            a = Int32.Parse(i = Console.ReadLine());
            Console.WriteLine(" Saisir la valeur de B : ");
            b = Int32.Parse(i  = Console.ReadLine());

            s = a + b;

            Console.Write(" La somme de " + a + " + " + b + " = " + s);

            Console.ReadKey();
        }
    }
}
