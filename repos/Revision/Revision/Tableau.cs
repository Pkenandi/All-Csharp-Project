using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    class Tableau
    {
        public static void Saisie()
        {
            int[,] Tab = new int[3, 3];

            for (int i = 0; i <= 2; i++)

                for (int j = 0; j <= 2; j++)
                {

                    Console.Write(" Element <" + (i + 1) + "> <" + (j + 1) + ">");
                    Tab[i, j] = int.Parse(Console.ReadLine());

                }


            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)

                    Console.Write("[ " + Tab[i, j] + "] ");

            }
        }
    }
}
