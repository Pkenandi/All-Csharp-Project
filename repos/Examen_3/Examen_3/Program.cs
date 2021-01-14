using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Examen_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //DataTable Tab = new DataTable();
            DBconnection.Connect();
            Console.WriteLine(" You're connected !!! \n");

            //PRL.AfficherEnteteFacture(12);
            //PRL.AfficherDetailsReglements(new DataTable(),12);
            //PRL.AfficherBulanReglements(new DataTable(), 12);

            PRL.AfficherFactureReglements(12);

            DBconnection.DisConnect();
            Console.ReadKey();
        }
    }
}
