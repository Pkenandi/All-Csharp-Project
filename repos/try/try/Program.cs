using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @try
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = new int[] { 1, 2, 3, 4 };
            int i = 0;
            while (i <= tableau.Length)
            {
                Console.Write(tableau[i]);
                i++;
            }

        }
}
