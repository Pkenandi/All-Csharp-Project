using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; 

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            ExamenDAL.GetEtudiant(10);

        }
    }
}
